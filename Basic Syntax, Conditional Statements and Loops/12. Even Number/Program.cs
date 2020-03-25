using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            while (true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                number = Math.Abs(int.Parse(Console.ReadLine()));
            }
        }
    }
}
