using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            List<string> kids = new List<string>();
            char[] forbidenSymbols = new char[] { '@', '-', '!', ':', '>' };

            string text;
            while ((text = Console.ReadLine()) != "end")
            {
                StringBuilder result = new StringBuilder();
                foreach (var symbol in text)
                {
                    char resultSymbol = (char)(symbol - key);
                    result.Append(resultSymbol);
                }
                string textResult = result.ToString();

                string pattern = @"@(?<fullMatch>(?<name>[A-Za-z]+).*(?=[^-@!:>])*)!G!";
                Match kid = Regex.Match(textResult, pattern);
                string fullMatch = kid.Groups["fullMatch"].Value;
                string name = kid.Groups["name"].Value;
                bool notForbiden = true;
                foreach (var item in forbidenSymbols)
                {
                    if (fullMatch.Contains(item))
                    {
                        notForbiden = false;
                    }
                }
                if (notForbiden)
                {
                    kids.Add(name);
                }
            }
            kids.RemoveAll(x => x == "");
            Console.WriteLine(string.Join("\n", kids));
        }
    }
}
