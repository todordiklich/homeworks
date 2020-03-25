using System;

namespace Ch._06_Ex._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < number; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
}
