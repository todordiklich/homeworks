using System;

namespace Generate_0_1_vector__solution_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bits(3, "");
        }
        static void Bits(int n, string bits)
        {
            if (n == 0)
            {
                Console.WriteLine(bits);
                return;
            }
            Bits(n - 1, bits + "0");
            Bits(n - 1, bits + "1");
        }
    }
}
