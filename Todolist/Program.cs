using System;
using System.Collections.Generic;

namespace Todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<string> taskList = new List<string>();
            

            do
            {
                Console.WriteLine("*Welcome to my to do list app*");
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("Enter 1 to add task to the list");
                Console.WriteLine("Enter 2 to remove task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter an to do item: ");
                        string newTask = Console.ReadLine();
                        taskList.Add(newTask);
                        Console.WriteLine("Current tasks:");
                        foreach (string task in taskList)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the task to remove:");
                        string TaskToRemove = Console.ReadLine();
                        
                        if (taskList.Remove(TaskToRemove)) {
                            Console.WriteLine("Task removed.");
                        } else {
                            Console.WriteLine("Task not found.");
                        }
                       
                        Console.WriteLine("Current tasks:");
                        foreach (string task in taskList)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                    
                    case "3":
                        Console.WriteLine("Displaying the list..");
                        Console.WriteLine(" ");
                        Console.WriteLine("Current Tasks: ");
                        foreach (string task in taskList)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                }


            } while (input != "e");
            
        }
    }
}