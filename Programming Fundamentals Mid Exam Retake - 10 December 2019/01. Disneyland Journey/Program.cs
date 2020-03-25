﻿using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double moneySaved = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i % 2 == 1 && i != 1)
                {
                    moneySaved -= moneySaved * 0.16;
                }
                if (i % 4 == 0)
                {
                    moneySaved += moneySaved * 0.25;
                }
                moneySaved += journeyCost * 0.25;
            }
            if (moneySaved >= journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(moneySaved - journeyCost):F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {(journeyCost - moneySaved):F2}lv. more.");
            }
        }
    }
}
