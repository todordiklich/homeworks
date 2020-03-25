using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            // Regex regex = new Regex(pattern);
            // MatchCollection matches = regex.Matches(text);

            MatchCollection matches = Regex.Matches(text, pattern);

            string[] phones = matches.Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(", ", phones));

        }
    }
}
