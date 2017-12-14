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


            var lt = new ListTasks("TodoApp.txt");
            switch (args[0])
            {
                case "-l":
                    lt.List();
                    break;

                case "-a":
                    var at = new AddTask("TodoApp.txt", args[1]);
                    at.AddTaskToFile();
                    lt.List();
                    break;

                case "-r":
                    var rt = new RemoveTask("TodoApp.txt", Int32.Parse(args[1]));
                    rt.Remove();
                    lt.List();
                    break;

                case "-c":
                    var ct = new CheckTask("TodoApp.txt", Int32.Parse(args[1]));
                    ct.CheckLine();
                    lt.List();
                    break;
            }
        }
    }
}
