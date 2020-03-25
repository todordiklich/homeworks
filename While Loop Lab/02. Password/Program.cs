using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();

            string inputPass = Console.ReadLine();

            while (inputPass != pass)
            {
                inputPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
