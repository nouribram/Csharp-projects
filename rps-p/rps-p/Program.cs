using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps_p
{
    class Program
    {
        private static int playerChoice;

        static void Main(string[] args)
        {
            Random random = new Random();

            int playersScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to rp");

            while(playersScore!= 3 && enemyScore != 3)
            {
                Console.WriteLine("player score - " + playersScore + ". Enemy Score - " + enemyScore);
                Console.WriteLine("pls enter r for rock or p for paper or anything for scissor");
                string playChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 2);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy Chooses Rock");

                    switch (playerChoice) 
                    {
                        case 'r':
                            Console.WriteLine("Tie");
                            break;
                        case 'l':
                            Console.WriteLine("player wins this round");
                            playersScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this round");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy Choose paper.");

                    switch (playerChoice) 
                    {
                        case 'r':
                            Console.WriteLine("Enemy wins this round");
                            enemyScore++;
                            break;

                        case 'p':
                            Console.WriteLine("Tie");
                            break;

                            default:
                            Console.WriteLine("player won the round");
                            playersScore++;
                            break;
                    }
                }
                else 
                {

                    Console.WriteLine("Enemy chooses Scissors");

                    switch (playerChoice) 
                    {
                        case 'r':
                            Console.WriteLine("player this round");
                            playersScore++;
                            break;

                        case 'p':
                            Console.WriteLine("Enemy won this round");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;

                    }

                }


            }

            if (playerChoice == 3) 
            {
                Console.WriteLine("you won!");
            }
            else
            {
                Console.WriteLine("you lose");
            }
        }
    }
}
