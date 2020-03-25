using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main()
        {
            List<string> friends = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Report")
                {
                    break;
                }
                List<string> command = input.Split().ToList();
                if (command[0] == "Blacklist")
                {
                    string name = command[1];
                    if (friends.Contains(command[1]))
                    {
                        friends[friends.FindIndex(x => x.Equals(name))] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    if (friends[int.Parse(command[1])] != "Blacklisted" && friends[int.Parse(command[1])] != "Lost")
                    {
                        Console.WriteLine($"{friends[int.Parse(command[1])]} was lost due to an error.");
                        friends[int.Parse(command[1])] = "Lost";
                    }
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    if (0 <= index && index <= friends.Count - 1)
                    {
                        Console.WriteLine($"{friends[index]} changed his username to {command[2]}.");
                        friends[index] = command[2];
                    }
                }
            }
            int blacklistedNamesCount = 0;
            int lostNamesCount = 0;
            for (int i = 0; i < friends.Count; i++)
            {
                if (friends[i] == "Blacklisted")
                {
                    blacklistedNamesCount++;
                }
                if (friends[i] == "Lost")
                {
                    lostNamesCount++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
