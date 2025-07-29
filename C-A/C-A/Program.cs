using System;


namespace C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("To find the area of rectangle press r, for circle press any key");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the H of R");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter W of R");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }

            else 
            {
                Console.WriteLine("please enter the radius");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius *  radius);
               
            }

            Console.WriteLine("The Result is:" + result);
            Console.ReadKey();
        }
    }
}
