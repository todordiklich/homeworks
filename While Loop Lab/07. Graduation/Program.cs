using System;

namespace _07._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double total = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if(grade >= 4)
                {
                    total += grade;
                    counter++;
                }
                

            }
            Console.WriteLine($"{name} graduated. Average grade: {(total / 12):F2}");

        }
    }
}
