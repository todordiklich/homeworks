using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main()
        {
            List<int> targets = Console
                .ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int startPoints = targets.Sum();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game over")
                {
                    break;
                }
                List<string> commands = input
                    .Split(new char[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = commands[0];
                if (command == "Reverse")
                {
                    targets.Reverse();
                }
                else
                {
                    string direction = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int shootLength = int.Parse(commands[3]);
                    if (direction == "Left")
                    {
                        if (startIndex < 0 || startIndex > targets.Count - 1)
                        {
                            continue;
                        }
                        else
                        {
                            int shootIndex = startIndex - shootLength;
                            if (shootIndex < 0)
                            {
                                while (shootIndex < 0)
                                {
                                    shootIndex += targets.Count;
                                }
                            }
                            Shoot(shootIndex, targets);
                        }
                    }
                    else if (direction == "Right")
                    {
                        if (startIndex < 0 || startIndex > targets.Count - 1)
                        {
                            continue;
                        }
                        else
                        {
                            int shootIndex = startIndex + shootLength;
                            if (shootIndex > targets.Count - 1)
                            {
                                while (shootIndex > targets.Count - 1)
                                {
                                    shootIndex -= targets.Count;
                                }
                            }
                            Shoot(shootIndex, targets);
                        }
                    }
                }
            }
            int currentPoints = targets.Sum();
            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {startPoints - currentPoints} points!");
        }
        static List<int> Shoot(int index, List<int> targets)
        {
            if (targets[index] < 5)
            {
                targets[index] = 0;
            }
            else
            {
                targets[index] -= 5;
            }
            return targets;
        }
    }
}
