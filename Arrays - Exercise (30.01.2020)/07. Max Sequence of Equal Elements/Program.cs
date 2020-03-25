using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string bestSequence = "";
            string currentSequence = "";

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    currentSequence += arr[i] + " "; 
                }
                else
                {
                    currentSequence = "";
                }
                
                if (currentSequence.Length > bestSequence.Length)
                {
                    bestSequence = currentSequence + arr[i];
                }
            }
            Console.WriteLine(bestSequence);
        }
    }
}
