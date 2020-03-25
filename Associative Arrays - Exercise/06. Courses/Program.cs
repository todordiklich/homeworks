using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> coursesNames = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] source = input.Split(" : ");
                string key = source[0];
                string name = source[1];

                if (!coursesNames.ContainsKey(key))
                {
                    coursesNames.Add(key, new List<string>());
                    coursesNames[key].Add(name);
                }
                else
                {
                    List<string> members = coursesNames[key];
                    members.Add(name);
                    coursesNames[key] = members.OrderBy(x => x).ToList();
                }
            }
            
            coursesNames = coursesNames
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in coursesNames)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
