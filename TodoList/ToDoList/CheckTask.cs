using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoList
{
    class CheckTask : FileHandler
    {
        public int rowToCheck { get; set; }

        public CheckTask(string FileName, int rowToCheck) : base(FileName)
        {
            this.rowToCheck = rowToCheck - 1;
        }

        public void CheckLine()
        {
            ReadToDoFile();

            try
            {
                string line = textContent[rowToCheck];
                List<string> wordsInOneLine = line.Split(' ').ToList();
                var sb = new StringBuilder();

                wordsInOneLine.RemoveAt(0);
                sb.Append("[x] ");

                foreach (var word in wordsInOneLine)
                {
                    sb.Append(word + " ");
                }

                textContent[rowToCheck] = sb.ToString();
                WriteToDoFile();
                sb.Clear();
                wordsInOneLine.Clear();
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Unable to check: index is out of bound");
            }
            textContent.Clear();
        }
    }
}
