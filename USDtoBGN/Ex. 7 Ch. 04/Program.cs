using System;

namespace Ex._7_Ch._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 5;
            int sum = 0;
            for (int i = 1; i <= counter;)
            {
                string input = Console.ReadLine();
                int number;
                bool parsResult = int.TryParse(input, out number);

                if (parsResult)
                {
                    sum += number;
                    counter--;
                }
                else
                {
                    Console.WriteLine("Invalid number, try again...");
                    continue;
                }
            }
            Console.WriteLine($"\nThe result is: {sum}");
        }
    }
}
