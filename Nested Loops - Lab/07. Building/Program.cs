using System;

namespace _07._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorNumber = int.Parse(Console.ReadLine());
            int roomNumber = int.Parse(Console.ReadLine());

            for (int i = floorNumber; i >= 1; i--)
            {
                for (int j = 0; j < roomNumber; j++)
                {
                    if (i == floorNumber)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
