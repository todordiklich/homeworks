using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int reversionNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < reversionNumber; i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (j == 0)
                    {

                        temp = arr[j];
                    }
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = temp; 
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
