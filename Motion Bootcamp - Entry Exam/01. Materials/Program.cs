using System;

namespace _01._Materials
{
    class Program
    {
        static void Main(string[] args)
        {
            long yeld = long.Parse(Console.ReadLine());
            long days = 0;
            long materialAmount = 0;
            long workersConsumation = 26;

            while (true)
            {
                days++;
                if (days > 1)
                {
                    yeld -= 10;
                }
                if (yeld < 100)
                {
                    break;
                }
                materialAmount += yeld - workersConsumation;
            }
            if (materialAmount <= workersConsumation)
            {
                Console.WriteLine(days - 1);
                Console.WriteLine(materialAmount);
            }
            else
            {
                materialAmount -= workersConsumation;
                Console.WriteLine(days - 1);
                Console.WriteLine(materialAmount);
            }
        }
    }
}
