using System;

namespace _06._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            int min = int.MaxValue;

            while (num > counter)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < min)
                {
                    min = input;
                }

                counter++;
            }
            Console.WriteLine(min);
        }
    }
}
