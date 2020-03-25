using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main()
        {
            List<string> tanks = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Add")
                {
                    if (tanks.Contains(input[1]))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        tanks.Add(input[1]);
                        Console.WriteLine("Tank successfully bought");
                    }
                }
                else if (input[0] == "Remove")
                {
                    if (tanks.Contains(input[1]))
                    {
                        tanks.Remove(input[1]);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (input[0] == "Remove At")
                {
                    int index = int.Parse(input[1]);
                    if (0 <= index && index <= tanks.Count - 1)
                    {
                        tanks.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (input[0] == "Insert")
                {
                    int index = int.Parse(input[1]);
                    if (0 <= index && index <= tanks.Count - 1)
                    {
                        if (tanks.Contains(input[2]))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            tanks.Insert(index, input[2]);
                            Console.WriteLine("Tank successfully bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", tanks));
        }
    }
}
