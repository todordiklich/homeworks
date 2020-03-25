using System;

namespace Swimming_WR
{
    class Program
    {
        static void Main(string[] args)
        {
            // input --> recorSec; distanceMeters; timeMeterPerSeconds; --> all doubles
            // condition --> waterResistance every 15 meters - 12.5 sec --> Math.Floor
            // TODO --> calculate distance in sec which will be needed for DistanceMeters; difference between Ivan time and WR

            //input
            double recordSec = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeMeterPerSeconds = double.Parse(Console.ReadLine());

            //logic
            double secIvanSwim = distanceMeters * timeMeterPerSeconds;
            double resistanceCoeficent = Math.Floor(distanceMeters / 15);
            double secDelay = resistanceCoeficent * 12.5;
            double sumIvanTime = secIvanSwim + secDelay;

            if (recordSec <= sumIvanTime)
            {
                Console.WriteLine($"No, he failed! He was {(sumIvanTime - recordSec):F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {sumIvanTime:F2} seconds.");
            }
        }
    }
}
