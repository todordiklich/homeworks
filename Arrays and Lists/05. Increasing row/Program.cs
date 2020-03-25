using System;

namespace _05._Increasing_row
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3, 4, 2, 2, 4, 7, 8 };
            int lenght = 1;
            int bestLenght = 1;            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    lenght++;
                }
                if (arr[i] + 1 != arr[i + 1])
                {
                    lenght = 1;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                }
            }

            int[] arrNew = new int[bestLenght];
            int counter = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1] && counter < bestLenght - 1)
                {
                    arrNew[counter] = arr[i];
                    counter++;
                }
                else if (i > 0 && arr[i] == arr[i - 1] + 1 && counter == bestLenght - 1)
                {
                    arrNew[counter] = arr[i];
                    counter++;
                }
            }

            for (int i = 0; i < bestLenght; i++)
            {
                Console.WriteLine($"{arrNew[i]}");
            }
        }
    }
}
