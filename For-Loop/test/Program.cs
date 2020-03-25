using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = (char)97; // a
            int a = 'a'; // 97
            double b = (int)5.66; // 5

            string text = "alabala";
            int length = text.Length;  // 7

            string text1 = "alabala1";
            int letterNumber = text1[3]; // 98
            char letter1 = text1[3]; // b
            double letter2 = text[3]; // 98
        }
    }
}
