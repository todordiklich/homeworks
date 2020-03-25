using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SmalestNumber(num1, num2, num3);
        }
        static void SmalestNumber(int num1, int num2, int num3)
        {
            int comp1 = Math.Min(num1, num2);
            int comp2 = Math.Min(comp1, num3);
            Console.WriteLine(comp2);

        }
    }
}
