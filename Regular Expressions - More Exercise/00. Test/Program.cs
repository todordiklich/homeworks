using System;

namespace _00._Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "1, 2, 3";
            string v = $" foo {{{t}}}";
            Console.WriteLine(v);
        }
    }
}
