using System;

namespace Unit_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // converting inputUnit in Meters, then converting Meters to neededUnit

            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string neededUnit = Console.ReadLine();

            if (inputUnit == "mm")
            {
                // mm --> m
                number = number / 1000;
            }
            else if (inputUnit == "cm")
            {
                //cm --> m
                number = number / 100;
            }

            if (neededUnit == "mm")
            {
                // m --> mm
                number = number * 1000;
            }
            else if ( neededUnit == "cm")
            {
                // m --> cm
                number = number * 100;
            }
            Console.WriteLine($"{number:F3}");
        }
    }
}
