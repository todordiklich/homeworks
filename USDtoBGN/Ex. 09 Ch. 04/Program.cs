using System;

namespace Ex._09_Ch._04
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (-b - Math.Sqrt(D)) / c;
            double x2 = (-b + Math.Sqrt(D)) / c;

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
