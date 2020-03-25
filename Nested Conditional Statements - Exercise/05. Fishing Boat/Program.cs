using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherNumber = int.Parse(Console.ReadLine());

            double price = 0.0;
            

            if (season == "Spring")
            {
                price = 3000.00;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200.00;
            }
            else if ( season == "Winter")
            {
                price = 2600.00;
            }

            if (fisherNumber <= 6)
            {
                price = price * 0.9;
            }
            else if (fisherNumber <= 11)
            {
                price = price * 0.85;
            }
            else
            {
                price = price * 0.75;
            }

            if (fisherNumber % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }

            
            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {(budget - price):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):F2} leva.");
            }
        }
    }
}
