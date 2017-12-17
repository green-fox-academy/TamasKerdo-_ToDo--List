using System;
using System.Text;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] a)
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

            var args = new string[2];
            args[0] = "-c";
            args[1] = "retek";


            switch (args[0])
            {
                case "-l":
                    var fh = new FileHandler("TodoApp.txt");
                    fh.List();
                    break;

                case "-a":
                    var at = new AddTask("TodoApp.txt", args[1]);
                    at.AddTaskToFile();
                    at.List();
                    break;

                case "-r":
                    var rt = new RemoveTask("TodoApp.txt", Int32.Parse(args[1]));
                    rt.Remove();
                    rt.List();
                    break;

                case "-c":
                    try
                    {
                        var ct = new CheckTask("TodoApp.txt", Int32.Parse(args[1]));
                        ct.CheckLine();
                        ct.List();
                        
                    }
                    catch (ArgumentNullException)
                    {

                        Console.WriteLine("Unable to check: no index provided");
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Unable to check: index is not a number");
                    }
                    
                    break;

                default:
                    break;


                    
            }
            Console.ReadLine();
        }
    }
}
