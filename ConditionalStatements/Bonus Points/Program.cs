using System;

namespace Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonus = 0.0;
            
            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            else
            {
                bonus = number * 0.2;
            }

            int additionalPoints = 0;

            if (number % 2 == 0)
            {
                additionalPoints = 1;
            }
            else if (number % 10 == 5)
            {
                additionalPoints = 2;
            }

            double sumBonusPoints = bonus + additionalPoints;
            Console.WriteLine(sumBonusPoints);
            Console.WriteLine(sumBonusPoints + number);

        }
    }
}
