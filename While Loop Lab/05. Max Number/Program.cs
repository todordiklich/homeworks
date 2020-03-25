using System;

namespace _05._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int count = 0;
            int max = int.MinValue;

            while (numbers > count)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > max)
                {
                    max = input;
                }
                count++;
            }
            Console.WriteLine(max);
        }
    }
}
