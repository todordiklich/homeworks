using System;

namespace _13._Find_sum_of__matrix_3x3_in_matrix_NxM
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[n, m];

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //       int number = int.Parse(Console.ReadLine());
            //    }
            //}

            // sample matrix n & m = 5
            int n = 5;
            int m = 5;
            int[,] matrix =
            {
                {1,  2,  3,  4,  5 },
                {6,  7,  8,  9,  10 },
                {11, 12, 13, 14, 15 },
                {16, 17, 18, 19, 20 },
                {21, 22, 23, 24, 25 }
            };

            // finding the biggest sum in matrix 3x3
            int sum = 0;
            int bestSum = int.MinValue;
            int bestRowStart = 0;
            int bestColStart = 0;
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRowStart = row;
                        bestColStart = col;
                    }
                }
            }
            Console.WriteLine($"The best Sum is: {bestSum}");
            Console.WriteLine();

            for (int i = bestRowStart; i <= bestRowStart + 2; i++)
            {
                for (int j = bestColStart; j <= bestColStart + 2; j++)
                {
                    Console.Write($"{matrix[i, j], 4}");
                }
                Console.WriteLine();
            }
        }
    }
}
