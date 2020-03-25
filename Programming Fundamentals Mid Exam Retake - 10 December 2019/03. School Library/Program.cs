using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._School_Library
{
    class Program
    {
        static void Main()
        {
            List<string> books = Console.ReadLine()
                .Split('&')
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                List<string> commands = input.Split(" | ", StringSplitOptions.None).ToList();
                if (commands[0] == "Add Book")
                {
                    if (books.Contains(commands[1]))
                    {
                        continue;
                    }
                    else
                    {
                        books.Insert(0, commands[1]);
                    }
                }
                else if (commands[0] == "Take Book")
                {
                    if (books.Contains(commands[1]))
                    {
                        books.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Swap Books")
                {
                    if (books.Contains(commands[1]) && books.Contains(commands[2]))
                    {
                        int firstBookIndex = books.IndexOf(commands[1]);
                        int secondBookIndex = books.IndexOf(commands[2]);
                        string temp = commands[1];
                        books[firstBookIndex] = commands[2];
                        books[secondBookIndex] = temp;
                    }
                }
                else if (commands[0] == "Insert Book")
                {
                    books.Add(commands[1]);
                }
                else if (commands[0] == "Check Book")
                {
                    if (0 <= int.Parse(commands[1]) && int.Parse(commands[1]) <= books.Count - 1)
                    {
                        Console.WriteLine(books[int.Parse(commands[1])]);
                    }
                }

            }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}
