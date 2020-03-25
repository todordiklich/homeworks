using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            if (month == "May" || month == "October")
            {
                apartmentPrice = 65.00;
                studioPrice = 50.00;
                if (nights > 7 && nights <= 13)
                {
                    studioPrice = studioPrice * 0.95;
                }
                else if (nights > 14)
                {
                    studioPrice = studioPrice * 0.7;
                }
            }
            else if (month == "June" || month == "September")
            {
                apartmentPrice = 68.70;
                studioPrice = 75.20;
                if (nights > 14)
                {
                    studioPrice = studioPrice * 0.8;
                }
            }
            else if (month == "July" || month == "August")
            {
                apartmentPrice = 77.00;
                studioPrice = 76.00;
            }

            if (nights > 14)
            {
                apartmentPrice = apartmentPrice * 0.9;
            }
            double apartmentCosts = nights * apartmentPrice;
            double studioCosts = nights * studioPrice;
            Console.WriteLine($"Apartment: {apartmentCosts:f2} lv.");
            Console.WriteLine($"Studio: {studioCosts:f2} lv.");
            
        }
    }
}
