using System;

namespace Ex._04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"one\two\three";
            string[] arr = str.Split('\\');
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
