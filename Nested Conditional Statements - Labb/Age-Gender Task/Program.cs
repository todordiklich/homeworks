﻿using System;

namespace Age_Gender_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (gender == 'm' && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (gender == 'm' && age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (gender == 'f' && age < 16)
            {
                Console.WriteLine("Miss");
            }
            else if (gender == 'f' && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
