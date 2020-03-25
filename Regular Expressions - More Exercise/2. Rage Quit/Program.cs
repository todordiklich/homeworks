using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToUpper();

            string wordDigitPattern = @"\D+\d+";
            string wordPattern = @"\D+";
            string digitPattern = @"\d+";

            StringBuilder result = new StringBuilder();
            List<char> uniqueSymbols = new List<char>();

            MatchCollection matches = Regex.Matches(text, wordDigitPattern);

            foreach (Match match in matches)
            {
                string word = Regex.Match(match.Value, wordPattern).ToString();
                int digit = int.Parse(Regex.Match(match.Value, digitPattern).ToString());
                if (digit != 0)
                {
                    string currentResult = new String('a', digit).Replace("a", word);
                    result.Append(currentResult);
                    char[] symbols = word.ToCharArray();
                    foreach (var symbol in symbols)
                    {
                        if (!uniqueSymbols.Contains(symbol))
                        {
                            uniqueSymbols.Add(symbol);
                        }
                    }
                }
            }
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result);
        }
    }
}
