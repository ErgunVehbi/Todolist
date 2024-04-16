using System;

namespace Todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            do
            {
                Console.WriteLine("*Welcome to my to do list app*");
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("Enter 1 to add task to the list");
                Console.WriteLine("Enter 2 to remove task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");
                input = Console.ReadLine();
                

            } 
            while (input !="e");
            
            
        }
        
        //how to approach: 
        
        //input -output 
        //once input is received add the input string to the list
        //
        
        
    }
}