using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    class Program
    {
        static void Main()
        {
            List<char> firstGroup = new List<char>();
            Dictionary<char, int> secondGroup = new Dictionary<char, int>();
            List<string> thirdGroup = new List<string>();

            string[] text = Console.ReadLine().Split("|");
            string firstText = text[0];
            string secondText = text[1];
            string thirdText = text[2];

            thirdGroup = thirdText.Split().ToList();

            string firstGroupPattern = @"([#$%*&])(?<first>[A-Z]+)\1";
            string secondGroupPattern = @"(?<second>(?:6[5-9]|[78][0-9]|90):(?:0[1-9]|1[0-9]|20))";

            // finding all [A-Z] letters in the first part
            MatchCollection firstMatches = Regex.Matches(firstText, firstGroupPattern);
            foreach (Match match in firstMatches)
            {
                string currentMatch = match.Groups["first"].Value;
                foreach (var letter in currentMatch)
                {
                    if (!firstGroup.Contains(letter))
                    {
                        firstGroup.Add(letter);
                    }
                }
            }

            //finding all {asciiCode}:{length} pairs
            MatchCollection secondMatches = Regex.Matches(secondText, secondGroupPattern);
            foreach (Match match in secondMatches)
            {
                string currentMatch = match.Value;
                char key = (char)int.Parse(currentMatch.Substring(0, 2));
                int value = int.Parse(currentMatch.Substring(3));
                if (!secondGroup.Keys.Contains(key))
                {
                    secondGroup.Add(key, value);
                }
            }

            char[] firstGroupArr = firstGroup.ToArray();
            for (int i = 0; i < firstGroup.Count; i++)
            {
                
                if (secondGroup.Keys.Contains(firstGroupArr[i]))
                {

                    foreach (var word in thirdGroup)
                    {
                        if (word.StartsWith(firstGroupArr[i]) && word.Length == secondGroup[firstGroup[i]] + 1)
                        {
                            Console.WriteLine(word);
                        }
                    }
                }
            }
        }
    }
}
