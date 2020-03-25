using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int totalSum = 0;

            foreach (var ch in text)
            {
                if (ch > start && ch < end)
                {
                    totalSum += ch;
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
