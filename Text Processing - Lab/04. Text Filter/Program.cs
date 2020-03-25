﻿using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannList = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannList)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
