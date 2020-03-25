using System;

namespace _05._Creating_DateTime_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime halloween = new DateTime(2011, 10, 31);
            Console.WriteLine(halloween);

            DateTime julyMorning = new DateTime(2011, 7, 1, 5, 52, 0);
            Console.WriteLine(julyMorning);

            DateTime dayAfterHalloween = halloween.AddDays(1);
            Console.WriteLine(dayAfterHalloween);
        }
    }
}
