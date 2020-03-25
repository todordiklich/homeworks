using System;

namespace _04._Sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == number)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {number})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {number}");
        }
    }
}
