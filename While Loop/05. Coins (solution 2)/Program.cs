using System;

namespace _05._Coins__solution_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeDeciaml = double.Parse(Console.ReadLine());
            double change = changeDeciaml * 100;
            int counter = 0;


            while (change >= 200)
            {
                change -= 200;
                counter++;
            }

            while (change >= 100)
            {
                change -= 100;
                counter++;
            }
            while (change >= 50)
            {
                change -= 50;
                counter++;
            }
            while (change >= 20)
            {
                change -= 20;
                counter++;
            }
            while (change >= 10)
            {
                change -= 10;
                counter++;
            }
            while (change >= 5)
            {
                change -= 5;
                counter++;
            }
            while (change >= 2)
            {
                change -= 2;
                counter++;
            }
            while (change >= 1)
            {
                change -= 1;
                counter++;
            }


            Console.WriteLine(counter);
        }
    }
}
