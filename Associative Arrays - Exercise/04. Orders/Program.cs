using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] source = input.Split();
                string key = source[0];
                double price = double.Parse(source[1]);
                double quantity = double.Parse(source[2]);

                if (!products.ContainsKey(key))
                {
                    products.Add(key, new List<double>());
                    products[key].Add(price);
                    products[key].Add(quantity);
                }
                else
                {
                    List<double> listPriceQuantity = products[key];
                    listPriceQuantity[0] = price;
                    listPriceQuantity[1] += quantity;
                }
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
            }
        }
    }
}
