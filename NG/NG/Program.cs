using System;


namespace NG
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);


            Console.WriteLine("Welcome Nourhan");
            Console.WriteLine("If you guess the correct number, you win!");
            

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter a number");

                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else
                {
                    Console.WriteLine("Correct");
                    isCorrectGuess = true;
                }
            
            }

            Console.WriteLine("Congratulations");

            Console.ReadKey();
        }
    }
}
