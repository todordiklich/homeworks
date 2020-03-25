using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 18.00;
            double discount = 0.0;

            if (roomType == "apartment")
            {
                price = 25.00;
                if(nights < 10)
                {
                    discount = 0.3;
                }
                else if ( nights >= 10 && nights <= 15)
                {
                    discount = 0.35;
                }
                else
                {
                    discount = 0.5;
                }

            }
            else if (roomType == "president apartment")
            {
                price = 35.00;
                if (nights < 10)
                {
                    discount = 0.1;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.2;
                }
            }
            double moneyForNights = nights * (price * (1 - discount));
            double addFee = 0.0;

            if (rating == "positive")
            {
                addFee = moneyForNights * 0.25;
            }
            else
            {
                addFee = - (moneyForNights * 0.1);
            }

            double moneyNeeded = moneyForNights + addFee;
            Console.WriteLine($"{moneyNeeded:f2}");
            
        }
    }
}
