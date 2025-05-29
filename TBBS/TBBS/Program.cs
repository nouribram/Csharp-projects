using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBBS
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(100, 20, 12, "player");
            Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
            Random random = new Random();


            while (!player.IsDead && !enemy.IsDead)
            {


                Console.WriteLine(player.UnitName + "HP = " + player.Hp + "." + enemy.UnitName + "HP = " + enemy.Hp);

                Console.WriteLine("player turn! what will you do?");
                string choice = Console.ReadLine();

                if (choice == "a")
                    player.Attack(enemy);
                else
                    player.Heal();



                if (player.IsDead || enemy.IsDead) break;


                Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);

                Console.WriteLine("Enemy turn!");

                int rand = random.Next(0, 2);

                if (rand == 0)
                    enemy.Attack(player);
                else
                    enemy.Heal();
            }
        }
    }
}