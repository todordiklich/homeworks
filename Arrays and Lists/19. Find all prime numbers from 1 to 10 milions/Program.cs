using System;

namespace _19._Find_all_prime_numbers_from_1_to_10_milions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            for (int i = 2; i <= 100; i++)
            {
                isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
