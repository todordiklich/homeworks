using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            do
            {
                int product = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {product}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
