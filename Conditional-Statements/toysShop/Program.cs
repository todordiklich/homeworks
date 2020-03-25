using System;

namespace toysShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleNumber = int.Parse(Console.ReadLine());
            int dollNumber = int.Parse(Console.ReadLine());
            int bearNumber = int.Parse(Console.ReadLine());
            int minionNumber = int.Parse(Console.ReadLine());
            int truckNumber = int.Parse(Console.ReadLine());

            //logic
            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double puzzleMoney = puzzleNumber * puzzlePrice;
            double dollMoney = dollNumber * dollPrice;
            double bearMoney = bearNumber * bearPrice;
            double minionMoney = minionNumber * minionPrice;
            double truckMoney = truckNumber * truckPrice;

            double allMoney = puzzleMoney + dollMoney + bearMoney + minionMoney + truckMoney;
            double allToys = puzzleNumber + dollNumber + bearNumber + minionNumber + truckNumber;
            double discount = 0.0;
            
            if (allToys >= 50)
            {
                discount = allMoney * 0.25;
            }
            double allEarned = allMoney - discount;
            double moneyEarned = allEarned * (1 - 0.1);
            

            if (moneyEarned >= vacationPrice)
            {
                double moneyHave = moneyEarned - vacationPrice;
                Console.WriteLine($"Yes! {moneyHave:F2} lv left.");
            }
            else
            {
                double moneyNeeded = vacationPrice - moneyEarned;
                Console.WriteLine($"Not enought Money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
