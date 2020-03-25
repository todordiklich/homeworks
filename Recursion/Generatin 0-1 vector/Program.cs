using System;

namespace Generatin_0_1_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int[] vector = new int[size];
            Gen01(size - 1, vector);
        }
        static void Gen01(int index, int[] vector)
        {
            if (index == -1)
            {
                Print(vector);
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Gen01(index - 1, vector);
                }
            }
        }
        static void Print(int[] vector)
        {
            foreach (var item in vector)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
