using System;

namespace _01._Reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            ReverseArray(arr, arr.Length -1);
        }
        static void ReverseArray(int[] array, int index)
        {
            if (index < 0)
            {
                return;
            }
            Console.Write(array[index] + " ");
            ReverseArray(array, index -1);
        }
    }
}
