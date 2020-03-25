using System;

namespace _05._Traveling
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
                double budget = double.Parse(Console.ReadLine());
                double moneySaved = 0;
                
                while (true)
                {
                    double money = double.Parse(Console.ReadLine());
                    moneySaved += money;
                    if (moneySaved >= budget)
                    {
                        Console.WriteLine($"Going to {destination}");
                        break;
                    }
                }
            }
        }
    }
}
