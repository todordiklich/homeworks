using System;

namespace Ex._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ms = Environment.TickCount;
            int msToSec = ms / 1000;
            int sec = msToSec % 60;
            int min = (msToSec / 60) % 60;
            int hour = (msToSec / 3600) % 24;
            int days = msToSec / 86400;

            Console.WriteLine($"{days} days - {hour:D2}:{min:D2}:{sec:D2}");
        }
    }
}
