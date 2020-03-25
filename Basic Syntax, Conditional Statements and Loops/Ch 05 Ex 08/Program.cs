using System;

namespace Ch_05_Ex_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double number;
            bool command = double.TryParse(input, out number);

            if (command)
            {
                Console.WriteLine(number + 1);
            }
            else
            {
                Console.WriteLine($"{input}*");
            }
        }
    }
}
