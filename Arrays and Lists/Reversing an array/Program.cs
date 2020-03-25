using System;

namespace Reversing_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int lenght = arr.Length;
            int[] reversedArr = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                reversedArr[lenght - 1 - i] = arr[i];
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"{reversedArr[i]}");
            }
        }
    }
}
