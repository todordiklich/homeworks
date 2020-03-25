using System;

namespace _08._Graduation_pt._2
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
                if (grade >= 4)
                {
                    total += grade;
                    counter++;
                }
                else
                {
                    grade = double.Parse(Console.ReadLine());
                    if (grade < 4)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        break;
                    }
                    total += grade;
                    counter++;
                }

            }
            if (counter == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(total / 12):F2}");
            }
        }
    }
}
