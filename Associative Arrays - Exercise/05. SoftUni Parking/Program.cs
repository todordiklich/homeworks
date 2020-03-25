using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkinPlaces = new Dictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string userName = input[1];
                if (command == "register")
                {
                    string numberPlate = input[2];
                    if (!parkinPlaces.ContainsKey(userName))
                    {
                        parkinPlaces[userName] = numberPlate;
                        Console.WriteLine($"{userName} registered {numberPlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {numberPlate}");
                    }
                }
                else // unregister
                {
                    if (!parkinPlaces.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        parkinPlaces.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }
            foreach (var item in parkinPlaces)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
