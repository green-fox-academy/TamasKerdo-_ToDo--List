using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class ListTasks :FileHandler
    {
        public ListTasks(string FileName) : base(FileName)
        {
            
        }

        public void List()
        {
            ReadToDoFile();
            string line;
            string number;
            for (int i = 0; i < textContent.Count; i++)
            {
                number =  (i+1).ToString() + " - ";                
                line = textContent[i];  
                Console.WriteLine(number+ line);
            }
            textContent.Clear();
        }
    }
}

