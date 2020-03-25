using System;

namespace Declaring_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            //int[] myArray1 = { 1, 2, 3, 4, 5 };
            //myArray[0] = 1;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
                Console.WriteLine($"Element {i + 1} = {myArray[i]}");
            }

            //Creating a clone of an array
            int[] arr = { 11, 22, 33 };
            int[] arr2 = (int[])arr.Clone();

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
