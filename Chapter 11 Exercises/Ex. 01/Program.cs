using System;

namespace Ex._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(year);
            if (isLeap)
            {
                Console.WriteLine($"Yes, {year} year is leap.");
            }
            else
            {
                Console.WriteLine($"No, {year} year is not leap.");
            }
        }
    }
}
