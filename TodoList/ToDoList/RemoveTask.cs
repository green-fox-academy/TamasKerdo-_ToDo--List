using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class RemoveTask :FileHandler
    {
        public int LineToRemove { get; set; }

        public RemoveTask(string FileName, int LineToRemove) : base(FileName)
        {
            this.LineToRemove = LineToRemove;
        }

        public void Remove()
        {
            ReadToDoFile();

            try
            {
                textContent.RemoveAt(LineToRemove - 1);
                WriteToDoFile();
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Unable to remove: index is out of bound");
            }
            
            textContent.Clear();            
        }
    }
}
