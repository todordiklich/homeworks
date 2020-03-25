using System;

namespace familyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            // input --> budget 0.0; nightCnt 0; nightPrice 0.0; additionalMoney 0;
            // if nightCount > 7 --> nightPrice = nightPrice * (1 - 0.05)
            //print --> enought money... or ...money needed

            // input
            double budget = double.Parse(Console.ReadLine());
            int nightCnt = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            double additionalMoney = double.Parse(Console.ReadLine());

            //logic
            double discount = 0.0;
            if (nightCnt > 7)
            {
                discount = 0.05;
            }
            double nightMoney = (nightPrice * (1 - discount)) * nightCnt;
            double additionalMoneySpend = budget * (additionalMoney / 100);
            double allMoneyNeeded = nightMoney + additionalMoneySpend;
            double allMoneyLeft = budget - allMoneyNeeded;
            if (allMoneyNeeded <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {allMoneyLeft:F2} leva after vacation.");
            }
            else
            {
                double MoneyNeeded = allMoneyNeeded - budget;
                Console.WriteLine($"{MoneyNeeded:F2} leva needed.");
            }

        }
    }
}
