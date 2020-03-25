using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //Left
                for (int j = i; j > 0; j--)
                {
                        sumLeft += arr[j - 1];
                }
                //Right
                for (int j = i; j < arr.Length - 1; j++)
                {
                        sumRight += arr[j + 1];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    sumLeft = 0;
                    sumRight = 0;
                }
            }
                Console.WriteLine("no");
        }
    }
}
