﻿using System;
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
                string[] words = line.Split(' ');
                words[0] = number + words[1];
                line = " ";

                foreach (var word in words)
                {
                    line += word;
                }                
                Console.WriteLine(line);                
            }
            textContent.Clear();
        }

    }
}
