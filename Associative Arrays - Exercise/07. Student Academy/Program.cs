using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, double> students = new Dictionary<string, double>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, grade);
                }
                else
                {
                    students[name] = (students[name] + grade) / 2;
                }
            }
            students = students
                .Where(x => (x.Value >= 4.5))
                .OrderByDescending(x => x.Value)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {(student.Value):F2}");
            }
        }
    }
}
