using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            
            string[] arr = str.Substring(0).Split(' ');
            string[] arr1 = str1.Substring(0).Split(' ');
            
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr1[i] == arr[j])
                    {
                        Console.Write(arr1[i] + " ");
                    }
                }
            }
        }
    }
}
