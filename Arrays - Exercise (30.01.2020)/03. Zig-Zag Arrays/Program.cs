using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            string[] arr1 = new string[n];
            string str = "";
            string str1 = "";
            for (int i = 0; i < n; i++)
            {
                string currentNumbers = Console.ReadLine();
                if (i % 2 == 0)
                {
                    str += currentNumbers;
                    str += " ";
                }
                else
                {
                    str1 += currentNumbers;
                    str1 += " ";
                }

            }
            string[] strArr;
            string[] str1Arr;
            strArr = str.Split(' ');
            str1Arr = str1.Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = strArr[i];
                }
                else
                {
                    arr[i] = str1Arr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    arr1[i] = strArr[i+1];
                }
                else
                {
                    arr1[i] = str1Arr[i-1];
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}
