using System;

namespace Ex._02
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Number {i} = {rnd.Next(100, 201)}");
            }
        }
    }
}
