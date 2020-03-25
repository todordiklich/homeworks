using System;

namespace _09._Max_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum += arr[j];
                }
                sum += arr[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine(maxSum);
        }
    }
}
