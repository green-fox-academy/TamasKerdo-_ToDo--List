using System;
using System.Text;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteOutTheManual();

            //var args = new string[2];
            //args[0] = "-r";
            //args[1] = "iuyabdsc";

            switch (args[0])
            {
                case "-l":
                    var fh = new FileHandler("TodoApp.txt");
                    fh.List();
                    break;

                case "-a":
                    try
                    {
                        var at = new AddTask("TodoApp.txt", args[1]);
                        at.AddTaskToFile();
                        at.List();
                    }
                    catch (ArgumentNullException)
                    {

                        Console.WriteLine("Unable to add: no task provided");
                    }
                    break;

                case "-r":
                    try
                    {
                        var rt = new RemoveTask("TodoApp.txt", Int32.Parse(args[1]));
                        rt.Remove();
                        rt.List();
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Unable to remove: no index provided");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to remove: index is not a number");
                    }
                    break;

                case "-t":
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
                    WriteOutTheManual();
                    break;
            }
            Console.ReadLine();
        }

        static void WriteOutTheManual()
        {            
            Console.WriteLine("\n");
            Console.WriteLine("Command Line Todo application \n");
            Console.WriteLine("============================= \n");
            Console.WriteLine("Command line arguments:\n");
            Console.WriteLine("-l   Lists all the tasks\n");
            Console.WriteLine("-a   Adds a new task\n");
            Console.WriteLine("-r   Removes an task\n");
            Console.WriteLine("-t   Completes an task\n");
            Console.ReadLine();
        }
    }
}
