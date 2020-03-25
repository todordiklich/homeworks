using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            
            while (true)
            {
                string steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    goal -= stepsToHome;
                    if (goal <= 0)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    Console.WriteLine($"{goal} more steps to reach goal.");
                    break;
                }
                int stepsInt = int.Parse(steps);
                goal -= stepsInt;
                if (goal <= 0)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
            }
        }
    }
}
