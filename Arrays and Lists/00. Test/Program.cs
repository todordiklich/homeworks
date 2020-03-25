using System;

namespace _00._Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 6, 1, 8, 7, 9, 2 };
            Array.Sort(arr);
            Console.WriteLine("Sorted array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Index number: " + Array.BinarySearch(arr, 6));            
        }
    }
}
