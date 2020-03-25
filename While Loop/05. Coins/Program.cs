using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int counter = 0;


            while (change >= 2.00)
            {
                change -= 2.00;
                change = Math.Round(change, 2);
                counter++;
            }

            while (change >= 1.00)
            {
                change -= 1.00;
                change = Math.Round(change, 2);
                counter++;
            }
            while (change >= 0.50)
            {
                change -= 0.50;
                change = Math.Round(change, 2);
                counter++;
            }
            while (change >= 0.20)
            {
                change -= 0.20;
                change = Math.Round(change, 2);
                counter++;
            }
            while (change >= 0.10)
            {
                change -= 0.10;
                change = Math.Round(change, 2);
                counter++;
            }
            while (change >= 0.05)
            {
                change -= 0.05;
                change = Math.Round(change, 2);
                counter++;
            }
            while (change >= 0.02)
            {
                change -= 0.02;
                change = Math.Round(change, 2);
                counter++;
            }
            while (change >= 0.01)
            {
                change -= 0.01;
                change = Math.Round(change, 2);
                counter++;
            }
            
            
            Console.WriteLine(counter);
        }
    }
}
