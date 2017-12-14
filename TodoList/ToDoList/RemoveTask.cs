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
            textContent.RemoveAt(LineToRemove - 1);
            WriteToDoFile();
            textContent.Clear();

            var modifiedFile = new ListTasks(FileName);
            modifiedFile.List();
        }
    }
}
