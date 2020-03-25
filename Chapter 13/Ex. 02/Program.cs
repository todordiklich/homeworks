using System;
using System.Text;

namespace Ex._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "introduction";
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
