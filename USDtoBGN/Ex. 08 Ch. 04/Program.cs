using System;

namespace Ex._08_Ch._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                num2 = num1;
            }
            if (num3 > num4)
            {
                num4 = num3;
            }
            if (num2 > num4)
            {
                num4 = num2;
            }
            if (num4 > num5)
            {
                num5 = num4;
            }
            Console.WriteLine(num5);
        }
    }
}
