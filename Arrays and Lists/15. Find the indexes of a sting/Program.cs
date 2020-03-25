using System;

namespace _15._Find_the_indexes_of_a_sting
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 52;
            char[] letters = new char[count];
            for (int i = 0; i < count / 2; i++)
            {
                letters[i] = (char)(i + 65);
            }
            for (int i = count / 2; i < count; i++)
            {
                letters[i] = (char)(i + 65 + 6);
            }

            Console.Write("Tipe a word = ");
            string word = Console.ReadLine();

            int[] letttersInWordArr = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                letttersInWordArr[i] = word[i];
            }

            //printing the result
            Console.WriteLine();
            Console.Write("{");
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (letttersInWordArr[i] == letters[j])
                    {
                        Console.Write($"{j,3},");
                        break;
                    }
                }
            }
            Console.WriteLine(" }");

        }
    }
}


