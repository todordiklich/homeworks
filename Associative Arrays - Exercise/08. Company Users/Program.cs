using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] source = input
                    .Split("->")
                    .Select(x => x.Trim())
                    .ToArray();
                string key = source[0];
                string id = source[1];

                if (!companies.ContainsKey(key))
                {
                    companies.Add(key, new List<string>());
                    companies[key].Add(id);
                }
                else
                {
                    if (!companies[key].Contains(id))
                    {
                        companies[key].Add(id);
                    }
                }
            }
            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
