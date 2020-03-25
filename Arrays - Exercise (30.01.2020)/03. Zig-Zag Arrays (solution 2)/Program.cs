using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays__solution_2_
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string[] firstArray = new string[number];
            string[] secondArray = new string[number];

            for (int index = 0; index < number; index++)
            {
                string[] input = Console.ReadLine().Split();

                if (index % 2 == 0)
                {
                    firstArray[index] = input[0];
                    secondArray[index] = input[1];
                }
                else
                {
                    secondArray[index] = input[0];
                    firstArray[index] = input[1];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
