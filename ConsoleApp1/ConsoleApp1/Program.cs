using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            
            Console.WriteLine("Welcome to the program");
            Console.WriteLine("Please enter the first number");
           
             int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");

             int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operator + * - / ");

             string op = Console.ReadLine();

            if (op == "+")
                {
                 result = number1 + number2;
            }
            else if (op == "-")
            {
                result = number1 - number2;
            }
            else if (op == "*")
            {
                result = number1 * number2;
            }
            else
            {
            result = number1 / number2;
            }

            Console.WriteLine("The answer is" + result);

                Console.ReadKey();  
        }
    }
}
