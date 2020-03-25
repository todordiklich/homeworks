using System;

namespace Ch_05_Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -5;
            int b = 8;
            int c = -12;

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int midValue = 0;

            if (a < minValue)
            {
                minValue = a;
            }
            if (b < minValue)
            {
                minValue = b;
            }
            if (c < minValue)
            {
                minValue = c;
            }

            if (a > maxValue)
            {
                maxValue = a;
            }
            if (b > maxValue)
            {
                maxValue = b;
            }
            if (c > maxValue)
            {
                maxValue = c;
            }

            if (a > minValue && a < maxValue)
            {
                midValue = a;
            }
            if (b > minValue && b < maxValue)
            {
                midValue = b;
            }
            if (c > minValue && c < maxValue)
            {
                midValue = c;
            }

            Console.WriteLine($"{minValue} {midValue} {maxValue}");
        }
    }
}
