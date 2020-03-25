using System;

namespace Godzila_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            int numActers = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            //logic
            double decor = budget * 0.1;
            double moneyForClothes = numActers * clothesPrice;

            if (numActers > 150)
            {
                moneyForClothes = moneyForClothes * (1 - 0.1);
            }
            double sumMoneyNeeded = moneyForClothes + decor;

            if (sumMoneyNeeded > budget)
            {
                double moneyNeeded = sumMoneyNeeded - budget;
                Console.WriteLine("Not enought money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
            else
            {
                double moneyLeft = budget - sumMoneyNeeded;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts film with {moneyLeft:F2} leva left.");
            }

        }
    }
}
