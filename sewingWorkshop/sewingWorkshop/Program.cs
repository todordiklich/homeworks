using System;

namespace sewingWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // number of tables
            // tableLenght in meters
            // tableWidth in meters
            // 1 USD = 1.85 BGN

            //input
            int tables = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            //logic
            double tableClotheArea = tables * (tableLenght + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double tableCoverArea = tables * (tableLenght / 2) * (tableLenght / 2);
            double priceUsd = (tableClotheArea * 7) + (tableCoverArea * 9);
            double usdRate = 1.85;
            double priceBgn = priceUsd * usdRate;

            //print
            Console.WriteLine($"{ priceUsd:F2} USD");
            Console.WriteLine($"{priceBgn:F2} BGN");






        }
    }
}
