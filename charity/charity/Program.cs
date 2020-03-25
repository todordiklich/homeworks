using System;

namespace charity
{
    class Program
    {
        static void Main(string[] args)
        {
            // numberDays & numberConfectioner = ?
            // numberCaces ; numberCorrugation ; numberPancake from one confectioner per day
            // cace = 45 lv ; corrugation = 5.80 lv ; pancake = 3.20 lv
            // 1/8 of the tottal money collected will be for costs --> 0.125
            // moneyCollected F:2

            //input
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int caces = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            //logic
            double cacePrice = 45;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            double caceMoney = caces * cacePrice;
            double waffleMoney = waffles * wafflePrice;
            double pancakeMoney = pancakes * pancakePrice;

            double moneyPerDay = (caceMoney + waffleMoney + pancakeMoney) * confectioners;
            double allMoney = moneyPerDay * days;
            double expences = allMoney / 8;
            double charityMoney = allMoney - expences;

            //print
            Console.WriteLine($"{charityMoney:F2}");



        }
    }
}
