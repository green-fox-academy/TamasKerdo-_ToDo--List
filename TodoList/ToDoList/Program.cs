using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Command Line Todo application \n");
            Console.WriteLine("============================= \n");            
            Console.WriteLine("Command line arguments:\n");
            Console.WriteLine("-l   Lists all the tasks\n");
            Console.WriteLine("-a   Adds a new task\n");
            Console.WriteLine("-r   Removes an task\n");
            Console.WriteLine("-c   Completes an task\n");
            Console.ReadLine();

            var fh = new FileHandler("TodoApp.txt","-l");
            fh.ReadToDoFile();
            fh.WriteToDoFile();
            Console.ReadLine();
        }
    }
}
