using System;

namespace _08._Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -3, 5, 8, -2 };
            int N = arr.Length;

            for (int i = 0; i < N - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i]; //1
                arr[i] = arr[min]; //-2
                arr[min] = temp; // 1

            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
