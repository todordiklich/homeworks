using System;
using System.Text.RegularExpressions;

namespace _04._RegEx_Replace
{
    class Program
    {

        static void Main()
        {
            string text = "marcus aurelius, the golden bowl, Thomas jefferson";
            string pattern = @"\b[a-z]\w+";
            string newText = Regex.Replace(text, pattern, delegate (Match match)
            {
                string v = match.Value;
                return char.ToUpper(v[0]) + v.Substring(1);
            });
            Console.WriteLine(newText);           


            //string input = "This is   text with   far  too   much   " +
            //         "white space.";
            //string pattern = @"\s+";
            //string replacement = " ";
            //string result = Regex.Replace(input, pattern, replacement);

            //Console.WriteLine("Original String: {0}", input);
            //Console.WriteLine("Replacement String: {0}", result);
        }
    }
}
