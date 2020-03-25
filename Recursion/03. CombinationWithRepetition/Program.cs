using System;

namespace _03._CombinationWithRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("k <= n");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
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
                Combinations(arr, end, index + 1, i);
            }
        }
    }
}
