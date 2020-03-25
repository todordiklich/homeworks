using System;

namespace Time__15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //logic
            int additionalMinutes = 15;
            int sumMinutes = minutes + additionalMinutes;
            int minutesToPrint = sumMinutes % 60;
            int hoursToAdd = sumMinutes / 60;
            int sumHours = hour + hoursToAdd;

            if (sumHours >= 24)
            {
                sumHours = sumHours % 24;
            }

            if (minutesToPrint < 10)
            {
                Console.WriteLine($"{sumHours}:0{minutesToPrint}");
            }
            else
            {
                Console.WriteLine($"{sumHours}:{minutesToPrint}");
            }
        }
    }
}
