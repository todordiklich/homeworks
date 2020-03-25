using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string str = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    str += arr[i] + " ";
                }
            }
            str += arr[arr.Length - 1];
            Console.WriteLine(str);
        }
    }
}
