using System;

namespace _04._Combinations_without_repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int k = 3;
            int[] arr = new int[k];
            Combinations(arr, n);
        }
        static void Combinations(int[] arr, int end, int index = 0, int start = 1)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;
                Combinations(arr, end, index + 1, i + 1);
            }
        }
    }
}
