using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList 
{
    class AddTask : FileHandler
    {
        public string InputTask { get; set; }

        public AddTask(string FileName, string InputTask) : base(FileName)
        {
            this.InputTask = InputTask;
        }

        public void AddTaskToFile()
        {
            ReadToDoFile();
            textContent.Add(InputTask);
            WriteToDoFile();
        }
    }
}
