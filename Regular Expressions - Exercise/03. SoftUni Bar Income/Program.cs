using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main()
        {
            double totalIncome = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                string pattern = @"^%(?<name>[A-Z][a-z]+)%(?:[^%|.$]*)<(?<product>\w+)>(?:[^%|.$]*)\|(?<count>\d+)\|(?:[^%|.$\d]*)(?<price>\d+\.?\d*)\$";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    string customer = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double income = double.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
                    totalIncome += income;
                    Console.WriteLine($"{customer}: {product} - {income:F2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
