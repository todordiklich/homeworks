using System;

namespace _07._Array_N____K_elements_with_max_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, -3, 5, 8, -4 };

            int K = 3;
            int N = array.Length;
            int sum = 0;
            int bestSum = int.MinValue;

            for (int i = 0; i <= N - K; i++)
            {
                for (int j = i; j < K + i; j++)
                {
                    sum += array[j];
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine(bestSum);
        }
    }
}
