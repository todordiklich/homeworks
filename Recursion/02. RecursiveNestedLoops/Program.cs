using System;

namespace _02._RecursiveNestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] arr = new int[n];            
            Recursion(0, arr, n);
        }
        static void Recursion(int index,int[] arr, int end)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = 1; i <= end; i++)
            {
                arr[index] = i;
                Recursion(index + 1, arr, end);
            }
        }
    }
}
