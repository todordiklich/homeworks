using System;
using System.Linq;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (text.Contains(key))
            {
                int startIndex = text.IndexOf(key);
                int ednIndex = key.Length;
                text = text.Remove(startIndex, ednIndex);
            }
            Console.WriteLine(text);
        }
    }
}
