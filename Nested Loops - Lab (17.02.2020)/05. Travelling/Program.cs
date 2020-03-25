using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double moneyNeeded = double.Parse(Console.ReadLine());
                double moneySaved = 0;
                while (true)
                {
                    double saving = double.Parse(Console.ReadLine());
                    moneySaved += saving;
                    if (moneyNeeded <= moneySaved)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
