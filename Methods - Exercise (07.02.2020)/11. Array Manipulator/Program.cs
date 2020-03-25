using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command[0] == 'e')
                {
                    arr = Exchange(command, arr);
                }
                else if (command[0] == 'm' && command[1] == 'a')
                {
                    MaxEvenOdd(command, arr);
                }
            }
        }
        static int[] Exchange(string str, int[] arr)
        {
            int index = str[str.Length-1] - '0';
            if (index > arr.Length)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }
            int[] resultArr = new int[arr.Length];
            int counter = 0;
            for (int i = index +1; i < arr.Length; i++)
            {
                resultArr[counter] = arr[i];
                counter++;
            }
            for (int i = 0; i <= index; i++)
            {
                resultArr[counter] = arr[i];
                counter++;
            }
            Console.WriteLine(string.Join(" ",resultArr));
            return resultArr;
        }

        static void MaxEvenOdd(string command, int[] arr)
        {
            if (command[4] == 'e')
            {
                int maxEven = int.MinValue;
                int maxEvenIndex = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] >= maxEven)
                    {
                        maxEven = arr[i];
                        maxEvenIndex = i;
                    }
                }
                if (maxEvenIndex > -1)
                {
                    Console.WriteLine(maxEvenIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
               
            }
            else
            {
                int maxOdd = int.MinValue;
                int maxOddIndex = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 1 && arr[i] >= maxOdd)
                    {
                        maxOdd = arr[i];
                        maxOddIndex = i;
                    }
                }
                if (maxOddIndex > -1)
                {
                    Console.WriteLine(maxOddIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }
    }
}
