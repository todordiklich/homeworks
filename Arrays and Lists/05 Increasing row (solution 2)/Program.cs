using System;

namespace _05_Increasing_row__solution_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3, 4, 2, 2, 4, };

            int count = 1, start = 0, maxCount = 1, maxStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStart = start;
                    }
                }
                else
                {
                    start = i;
                    count = 1;
                }
            }

            for (int i = maxStart; i < maxStart + maxCount; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }
}
