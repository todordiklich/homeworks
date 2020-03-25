using System;

namespace _20._Chech_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int sum = 14;
            Array.Sort(arr);
            
            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = i;
                for (int j = i +1; j < arr.Length; j++)
                {
                    currentSum += j;
                    if (currentSum == sum)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
        }
    }
}
