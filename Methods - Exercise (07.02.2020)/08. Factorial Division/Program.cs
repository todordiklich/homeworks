using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            FactorialDivision(num1, num2);
        }
        static void FactorialDivision(decimal num1, decimal num2)
        {
            decimal f1 = Factorial(num1);
            decimal f2 = Factorial(num2);
            Console.WriteLine($"{(f1/f2):F2}");

        }
        static decimal Factorial(decimal n)
        {
            decimal sum = 1;
            for (decimal i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
