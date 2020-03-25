using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelCount(input);
        }
        static void VowelCount(string input)
        {
            int counter = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (input[i] == vowels[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter); ;
        }
    }
}
