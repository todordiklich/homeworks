using System;

namespace _14._Find_the_best_sequense_of_equal_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix =
            {
                {"ha", "fifi", "ho" },
                {"fo", "ha", "hi" },
                {"xxx", "ho", "ha" }
            };
            string currentStr= "";
            string mostCommonstr = "";
            int lenght = 1;
            int bestLenght = 1;
            // row test
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    currentStr = matrix[row, col];
                    if (currentStr == matrix[row, col + 1])
                    {
                        lenght++;
                        if (lenght > bestLenght)
                        {
                            bestLenght = lenght;
                            mostCommonstr = currentStr;
                        }
                    }
                    else
                    {
                        lenght = 1;
                    }
                    
                }
            }

            //col test
            lenght = 1;
            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; row < 2; row++)
                {
                    currentStr = matrix[col, row];
                    if (currentStr == matrix[col, row + 1])
                    {
                        lenght++;
                        if (lenght > bestLenght)
                        {
                            bestLenght = lenght;
                            mostCommonstr = currentStr;
                        }
                    }
                    else
                    {
                        lenght = 1;
                    }

                }
            }

            // diagonal test
            lenght = 1;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    currentStr = matrix[row, col];
                    if (currentStr == matrix[row + 1, col + 1])
                    {
                        lenght++;
                        if (lenght > bestLenght)
                        {
                            bestLenght = lenght;
                            mostCommonstr = currentStr;
                        }
                    }

                }
            }

            Console.WriteLine($"The best lenght is: {bestLenght}");
            Console.WriteLine();
            Console.Write("{ ");
            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write(mostCommonstr + " ");
            }
            Console.WriteLine("}");
        }
    }
}
