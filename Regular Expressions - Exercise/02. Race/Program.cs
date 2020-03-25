using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, int> racers = new Dictionary<string, int>();
            foreach (var name in names)
            {
                racers.Add(name, 0);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }
                string namePattern = @"[A-Za-z]+";
                Regex regexName = new Regex(namePattern);
                MatchCollection nameMatches = regexName.Matches(input);
                string nameFound = "";
                foreach (Match match in nameMatches)
                {
                    nameFound += match.Value;
                }
                if (racers.ContainsKey(nameFound))
                {
                    string distancePattern = @"\d";
                    Regex regexDistance = new Regex(distancePattern);
                    MatchCollection distanceMatches = regexDistance.Matches(input);
                    int distance = 0;
                    foreach (Match match in distanceMatches)
                    {
                        distance += int.Parse(match.Value);
                    }
                    racers[nameFound] += distance;
                }
            }
            racers = racers.OrderByDescending(x => x.Value).ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"1st place: {racers.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {racers.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {racers.Keys.ElementAt(2)}");
        }
    }
}
