using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            AddSubrtact(num1, num2, num3);
        }
        static void AddSubrtact(int a, int b, int c) 
        {
            int sum = a + b;
            sum -= c;
            Console.WriteLine(sum);
        }

    }
}
