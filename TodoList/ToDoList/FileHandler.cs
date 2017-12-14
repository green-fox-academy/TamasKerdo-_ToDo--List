using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToDoList
{
    class FileHandler
    {
        public String FileName { get; set; }
        public String commandName { get; set; }
        public List<string> textContent { get; set; }

        public FileHandler(string FileName, string commandName)
        {
            this.FileName = FileName;
            this.commandName = commandName;
            textContent = new List<string>();

        }

        public void ReadToDoFile()
        {
            StreamReader sr = new StreamReader(FileName);
            string line;
                while ((line = sr.ReadLine()) != null)
                {
                Console.WriteLine(line);
                textContent.Add(line);                
                }
            sr.Close();
        }

        public void WriteToDoFile()
        {
            TextWriter tw = new StreamWriter(FileName);

            Console.ReadLine();
            for (int i = 0; i < textContent.Count; i++)
            {
                Console.WriteLine(textContent[i]);
                tw.WriteLine(textContent[i],false);
            }

            tw.Close();
        }

    }
}
