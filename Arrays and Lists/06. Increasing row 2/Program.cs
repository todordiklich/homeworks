using System;

namespace _06._Increasing_row_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

            int bestLength = 0;
            int[] bestResult = new int[array.Length];

            for (int start = 0; start < array.Length; start++)
            {
                int[] result = new int[array.Length];
                int resIndex = 1;
                int resLength = 1;
                result[0] = array[start];
                for (int i = start + 1; i < array.Length; i++)
                {
                    if (array[i] > result[resIndex - 1])
                    {
                        result[resIndex] = array[i];
                        resIndex++;
                        resLength++;
                    }
                    else if (resIndex > 1 && array[i] > result[resIndex - 2] && array[i] < result[resIndex - 1])
                    {
                        result[resIndex - 1] = array[i];
                    }
                }
                if (bestLength < resLength)
                {
                    bestLength = resLength;
                    bestResult = result;
                }
            }
            for (int j = 0; j < bestLength; j++)
            {
                Console.Write(bestResult[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
