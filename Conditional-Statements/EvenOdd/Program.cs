using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenOddLogic = number % 2;

            if (evenOddLogic == 0)
            {
                Console.WriteLine("Even");
            }
            else
                Console.WriteLine("Odd");

            
        }
    }
}
