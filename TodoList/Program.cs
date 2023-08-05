using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("ToDo List Application\n");

                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task description: ");
                        string task = Console.ReadLine();
                        todoList.Add(task);
                        Console.WriteLine("Task added!");
                        break;
                    case 2:
                        Console.WriteLine("\nTasks:");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
