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

        FileHandler(string FileName, string commandName)
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
                textContent.Add(line);
                }            
        }

        public void WriteToDoFile()
        {
            TextWriter tw = new StreamWriter(FileName);

            for (int i = 0; i < textContent.Count; i++)
            {
                tw.WriteLine(textContent[i],false);
            }

            tw.Close();
        }

    }
}
