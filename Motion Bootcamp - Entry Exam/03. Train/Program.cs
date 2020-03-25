using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Destination> destinations = new List<Destination>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Slide rule")
                {
                    break;
                }
                string[] input = command.Split(new string[] { ":", "->" }, StringSplitOptions.None);
                string townName = input[0];
                string timeStr = input[1];
                int passendegrsCount = int.Parse(input[2]);
                if (timeStr == "ambush")
                {
                    if (destinations.Select(x => x.TownName).Contains(townName))
                    {
                        int index = destinations.FindIndex(x => x.TownName == townName);
                        destinations[index].PassengersCount -= passendegrsCount;
                        destinations[index].Time = 0;
                    }
                }
                Destination destination = new Destination();
                if (destinations.Select(x => x.TownName).Contains(townName) && timeStr != "ambush")
                {
                    int time = int.Parse(input[1]);
                    int index = destinations.FindIndex(x => x.TownName == townName);
                    if (destinations[index].Time > time || destinations[index].Time == 0)
                    {
                        destinations[index].Time = time;
                    }
                    destinations[index].PassengersCount += passendegrsCount;
                }
                else if (timeStr != "ambush")
                {
                    int time = int.Parse(input[1]);
                    destination.TownName = townName;
                    destination.Time = time;
                    destination.PassengersCount = passendegrsCount;
                    destinations.Add(destination);
                }

            }
            destinations = destinations.OrderBy(x => x.Time).ThenBy(x => x.TownName).ToList();
            foreach (var item in destinations)
            {
                if (item.Time <= 0)
                {
                    continue;
                }
                else if (item.PassengersCount <= 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{item.TownName} -> Time: {item.Time} -> Passengers: {item.PassengersCount}");
                }
            }
        }
    }
}
