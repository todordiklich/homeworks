using System;

namespace Ch_05_Ex_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, -2, 1, 1, 8 };
            int counter = 0;
            /*
               Combinations:
               1, 2    1, 2, 3     1, 2, 3, 4     1, 2, 3, 4, 5
               1, 3    1, 2, 4     1, 2, 3, 5
               1, 4    1, 2, 5     1, 2, 4, 5
               1, 5    1, 3, 4     1, 3, 4, 5
               2, 3    1, 3, 5     2, 3, 4, 5
               2, 4    1, 4, 5
               2, 5    2, 3, 4
               3, 4    2, 3, 5
               3, 5    2, 4, 5
               4, 5    3, 4, 5
            */

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine($"{num[index], 5}");             
            }

        }
    }
}
