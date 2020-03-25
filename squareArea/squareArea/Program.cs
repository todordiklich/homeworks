using System;

namespace squareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double volumeDecimeters = volume * 0.001;
            double percentDecimeters = percent * 0.01;
            double result = volumeDecimeters * (1 - percentDecimeters);

            Console.WriteLine($"tova sa shibanite litri {result:F3} l.");

        }
    }
}
