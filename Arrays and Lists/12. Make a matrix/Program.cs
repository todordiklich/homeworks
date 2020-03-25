using System;

namespace _12._Make_a_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[,] matrix = new int[n, n];

            //// condition a
            //for (int i = 0; i < n * n; i++)
            //{
            //    int r = i % n;
            //    int c = i / n;
            //    matrix[r, c] = i + 1;
            //}

            //int count = 1;
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        matrix[col, row] = count;
            //        count++;
            //    }
            //}

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        Console.Write($"{matrix[row, col], 4}");
            //    }
            //    Console.WriteLine();
            //}

            ////condition b
            //for (int i = 0; i < n * n; i++)
            //{
            //    int r = i % n;
            //    int c = i / n;
            //    if (i / n % 2 > 0)
            //    {
            //        r = n - 1 - r;
            //    }
            //        matrix[r, c] = i + 1;
            //}

            //int count = 1;
            //int i;
            //for (int col = 0; col < n; col++)
            //{
            //    for (int row = 0; row < n; row++)
            //    {
            //        if (col % 2 == 0)
            //        {
            //            matrix[row, col] = count++;
            //        }
            //        else
            //        {
            //            i = n - 1 - row;
            //            matrix[i, col] = count++;
            //        }
            //    }
            //}

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        Console.Write($"{matrix[row, col], 4}");
            //    }
            //    Console.WriteLine();
            //}

            //// condition c
            //int intercept;
            //int row, col;
            //col = 0;
            //intercept = n - 1;
            //row = col + intercept;

            //for (int i = 0; i < n * n; i++)
            //{
            //    matrix[row, col] = i + 1;

            //    row++;
            //    col++;
            //    if (row > n - 1 || col > n - 1)
            //    {
            //        col = 0;
            //        intercept--;
            //        row = col + intercept;
            //        if (row < 0)
            //        {
            //            col -= row;
            //            row = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{matrix[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}

            // condition d
            int stepRows, stepCols, maxRow, minRow, maxCol, minCol;
            int row, col;
            row = col = 0;
            stepRows = 1;
            stepCols = 0;
            maxRow = maxCol = n - 1;
            minRow = minCol = 0;

            for (int i = 0; i < n * n; i++)
            {
                matrix[row, col] = i + 1;

                row += stepRows;
                col += stepCols;
                if (row > maxRow || col > maxCol ||
                    row < minRow || col < minCol)
                {
                    row -= stepRows;
                    col -= stepCols;
                    if (stepRows > 0)
                    {
                        minCol++;
                    }
                    if (stepRows < 0)
                    {
                        maxCol--;
                    }
                    if (stepCols > 0)
                    {
                        maxRow--;
                    }
                    if (stepCols < 0)
                    {
                        minRow++;
                    }
                    int swap = stepRows;
                    stepRows = (stepRows != 0 ? 0 : -stepCols);
                    stepCols = (stepCols != 0 ? 0 : swap);
                    row += stepRows;
                    col += stepCols;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
