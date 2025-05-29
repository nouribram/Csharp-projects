using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdl_p
{
    class Program
    {
        private static object taskList;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List Program!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove a task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Write("Please enter the name of the task to add to the list: ");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list.");
                }
                else if (option == "2")
                {
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("The task list is currently empty.");
                        continue;
                    }

                    Console.WriteLine("Current tasks:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i}: {taskList[i]}");
                    }

                    Console.Write("Please enter the number of the task to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber) &&
                        taskNumber >= 0 && taskNumber < taskList.Count)
                    {
                        taskList.RemoveAt(taskNumber);
                        Console.WriteLine("Task removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks:");
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("No tasks in the list.");
                    }
                    else
                    {
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i}: {taskList[i]}");
                        }
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting program...");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }

            Console.WriteLine("Thank you for using the program!");
        }


    }
}