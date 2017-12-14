using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class CheckTask : FileHandler
    {
        public int rowToCheck { get; set; }

        public CheckTask(string FileName, int rowToCheck) : base(FileName)
        {
            this.rowToCheck = rowToCheck;
        }

        public void CheckLine()
        {
            ReadToDoFile();
            if (textContent.Count >= rowToCheck)
            {                
                string line = textContent[rowToCheck];
                Console.WriteLine(line);
                string[] wordsInOneLine = line.Split(' ');
                wordsInOneLine[0] = "[x]";
                line = "";
                foreach (var word in wordsInOneLine)
                {
                    line += word+ " ";
                    Console.WriteLine(line);
                    
                }
                textContent[rowToCheck] = line;                
                WriteToDoFile();
            }
            textContent.Clear();
        }
    }
}
