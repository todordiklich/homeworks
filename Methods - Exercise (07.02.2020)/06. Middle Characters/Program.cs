using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            MidChar(str);
        }
        static void MidChar(string str)
        {
            int midChar = str.Length / 2;
            if (str.Length % 2 == 1)
            {
                Console.WriteLine(str[midChar]);
            }
            else
            {
                Console.WriteLine($"{str[midChar-1]}{str[midChar]}");
            }
        }
    }
}
