using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word[i].Length; j++)
                {
                    result += word[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
