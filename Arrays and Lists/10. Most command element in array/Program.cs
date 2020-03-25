using System;

namespace _10._Most_command_element_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 1, 1, 4 };

            int currentNumber = 0;
            int bestNumber = 0;
            int bestLenght = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentLenght = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentNumber = arr[i];
                        currentLenght++;
                        if (currentLenght > bestLenght)
                        {
                            bestLenght = currentLenght;
                            bestNumber = currentNumber;
                        }
                    }
                }
            }
            Console.WriteLine($"The most common number is: {bestNumber}, found: {bestLenght} times");

        }
    }
}
