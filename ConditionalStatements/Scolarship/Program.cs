using System;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScolarship = 0.0;
            double gradesScolarchip = 0.0;

            if (grade > 4.50)
            {
                if (income < minSalary)
                {
                    socialScolarship = minSalary * 0.35;
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            if (grade >= 5.50)
            {
                gradesScolarchip = grade * 25;

                if (gradesScolarchip >= socialScolarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradesScolarchip)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScolarship)} BGN");
                }
            }
            
        }
    }
}
