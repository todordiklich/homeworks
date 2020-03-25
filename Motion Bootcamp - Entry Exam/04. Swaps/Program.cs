using System;
using System.Linq;

namespace _04._Swaps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsColumns = Console.ReadLine().Split();
            int rows = int.Parse(rowsColumns[0]);
            int columns = int.Parse(rowsColumns[1]);
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] matrixRows = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = matrixRows[j];
                }
            }
            while (true)
            {
            string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "swap" && command.Length == 5)
                {
                    int firstRow = int.Parse(command[1]);
                    int secondRow = int.Parse(command[3]);
                    int firstCol = int.Parse(command[2]);
                    int secondCol = int.Parse(command[4]);
                    if (firstRow >= 0 && firstRow <= rows - 1 && firstCol >= 0 && firstCol <= columns - 1
                        && secondRow >= 0 && secondRow <= rows - 1 && secondCol >= 0 && secondCol <= columns - 1)
                    {
                        string temp = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = temp;
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

            }
            
        }
    }
}
