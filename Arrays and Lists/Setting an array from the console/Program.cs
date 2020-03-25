using System;

namespace Setting_an_array_from_the_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // cheching the symmetricity
            int lenght = arr.Length;
            bool isSymmetric = true;

            for (int i = 0; i < lenght / 2; i++)
            {
                if (arr[i] != arr[lenght - 1 - i])
                {
                    isSymmetric = false;
                }
            }
            if (isSymmetric)
            {
                Console.WriteLine("The array is symmetric.");
            }
            else
            {
                Console.WriteLine("The array is not symmetric.");
            }
        }
    }
}
