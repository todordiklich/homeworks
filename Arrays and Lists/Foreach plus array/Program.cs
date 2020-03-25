using System;

namespace Foreach_plus_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] towns = { "Gabrovo", "Varna", "Sofia", "Burgas", "Plovdiv" };

            foreach (var town in towns)
            {
                Console.WriteLine(town);
            }
        }
    }
}
