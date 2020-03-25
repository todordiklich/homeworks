using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Lumpawaroo")
                {
                    break;
                }
                string[] input = command.Split(new string[] { " | ", " -> " }, StringSplitOptions.None);
                if (command.Contains(" | "))
                {
                    string key = input[0];
                    string user = input[1];
                    bool doesNotContainUser = true;
                    foreach (var side in sides)
                    {
                        if (side.Value.Contains(user))
                            doesNotContainUser = false;
                    }
                    if (sides.ContainsKey(key))
                    {

                        if (doesNotContainUser)
                        {
                            sides[key].Add(user);
                        }
                    }
                    else
                    {
                        sides.Add(key, new List<string>());
                        if (doesNotContainUser)
                        {
                            sides[key].Add(user);
                        }
                    }
                }
                else
                {
                    string user = input[0];
                    string key = input[1];

                    foreach (var side in sides)
                    {
                        if (side.Value.Contains(user))
                        {
                            side.Value.Remove(user);
                        }
                    }
                    if (!sides.ContainsKey(key))
                    {
                        sides.Add(key, new List<string>());
                    }
                    sides[key].Add(user);
                    Console.WriteLine($"{user} joins the {key} side!");

                }
            }
            foreach (var side in sides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var user in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
