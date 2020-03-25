using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLenght = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int freeSpace = freeSpaceWidth * freeSpaceLenght * freeSpaceHeight;

            int boxesSpace = 0;

            while (command != "Done")
            {
                int boxCount = int.Parse(command);

                boxesSpace += boxCount;

                if (boxesSpace >= freeSpace)
                {
                    break;
                }

                command = Console.ReadLine();
            }
            if (boxesSpace > freeSpace)
            {
                Console.WriteLine($"No more free space! You need {boxesSpace - freeSpace} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace - boxesSpace} Cubic meters left.");
            }
        }
    }
}
