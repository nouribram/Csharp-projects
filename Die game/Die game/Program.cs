using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll ");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI Rolled " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {

                    playerPoints++;
                    Console.WriteLine("players win");

                }
                else if (enemyRandomNum > enemyPoints) {

                    enemyPoints++;
                    Console.WriteLine("enemy win");
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("the score is" + playerPoints + "Enemy score is" + enemyPoints);
            }
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("you win");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("you lose");
            }
            else
            {
                Console.WriteLine("Draw");
            }
                Console.ReadKey();

        }
    }
}
