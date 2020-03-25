using System;
using System.Globalization;

namespace _14._Dates_test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", CultureInfo.InvariantCulture);
            date = date.AddDays(1);

            Console.WriteLine($"{date:dd.mm.yyyy}");
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
