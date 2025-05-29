using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome please enter 'c' to use the currency converter or else for temp converter");
            string answer = Console.ReadLine();


            if (answer == "c")
            {
                Console.WriteLine("you have selected the currency converter");
                Console.WriteLine("Please enter 'a' to convert the currency to euros");
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.WriteLine("please enter your amount in british");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine(" the amount in euros is " + euros.ToString("0.00"));
                }

                else
                {
                    Console.WriteLine("please enter your amount");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    Console.WriteLine("the amount in british pounds is " + pounds.ToString("0.00"));
                }
            }

            else
            {
                Console.WriteLine("Welcome to the temp");
                Console.WriteLine("Please enter 'a' to convert to f ");
                string choice = Console.ReadLine();

                if (choice == "a")
                {

                    Console.WriteLine("Enter a tep in c ");
                    float celcuis = float.Parse(Console.ReadLine());
                    float farenheit = celcuis * 1.18f * 32f;
                    Console.WriteLine(" the temp in f" + farenheit);
                }
                else
                {
                    Console.WriteLine("please enter a temp");
                    float farenheit = float.Parse(Console.ReadLine());
                    float celcuis = (farenheit - 32f) / 1.8f;
                    Console.WriteLine("the temp in cel" + celcuis);
                }
            }
        }
    }
}