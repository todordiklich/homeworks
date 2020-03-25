using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main()
        {
            double totalPrice = 0;
            List<string> products = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                string pattern = @">>(?<product>\w+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    products.Add(match.Groups["product"].Value);
                    totalPrice += double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
