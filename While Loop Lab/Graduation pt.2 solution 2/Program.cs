using System;

namespace Graduation_pt._2_solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double total = 0;
            double excluded = 0;
            bool isExcluded = false;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    excluded++;
                }
                else if (grade >= 4)
                {
                    total += grade;
                    counter++;
                }
                if (excluded >= 2)
                {
                    isExcluded = true;
                    break;
                }
            }
            if (isExcluded)
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {(total / 12):F2}");
            }
            

        }
    }
}
