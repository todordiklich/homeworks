using System;

namespace Easy_sample_of_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion(5);
        }
        static void Recursion(int steps)
        {
            Console.WriteLine($"Called at: {steps}");
            if (steps <= 0)
            {
                Console.WriteLine($"Returns at: {steps}");
                return;
            }
            Recursion(steps - 1);
            Console.WriteLine($"Returns at: {steps}");
        }
    }
}
