using System;

namespace _11._Finding_a_given_sum_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
            int sum = 11;
            int startNumber = 0;
            int endNumber = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currnetSum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    currnetSum += arr[j];

                    if (sum == currnetSum)
                    {
                        startNumber = i;
                        endNumber = j;
                    }
                    if (currnetSum > sum)
                    {
                        break;
                    }
                }
            }
            Console.Write("{ ");
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("}");
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
