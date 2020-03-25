using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string placeToSleep = "";
            double expences = 0.0;

            if (budget <= 100)
            {
                place = "Bulgaria";
                if (season == "summer")
                {
                    placeToSleep = "Camp";
                    expences = budget * 0.3;
                }
                else // season = winter
                {
                    placeToSleep = "Hotel";
                    expences = budget * 0.7;
                }
            }

            else if (budget <= 1000)
            {
                place = "Balkans";
                if (season == "summer")
                {
                    placeToSleep = "Camp";
                    expences = budget * 0.4;
                }
                else // season = winter
                {
                    placeToSleep = "Hotel";
                    expences = budget * 0.8;
                }
            }

            else // budget > 1000
            {
                place = "Europe";
                placeToSleep = "Hotel";
                expences = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{placeToSleep} - {expences:F2}");
        }
    }
}
