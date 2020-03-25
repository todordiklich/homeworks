using System;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main()
        {
            string[] tickets = Console
                .ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"(\@{6,}|\#{6,}|\${6,}|\^{6,})";

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10);
                    Match matchFH = Regex.Match(firstHalf, pattern);
                    Match matchSH = Regex.Match(secondHalf, pattern);
                    if (matchFH.Length >= 6 && matchSH.Length >= 6)
                    {
                        int minLen = Math.Min(matchFH.Length, matchSH.Length);
                        string symbol = matchFH.Value.Substring(0, 1);
                        if (matchFH.Length == 10 && matchSH.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchSH.Length}{symbol} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minLen}{symbol}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }

                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }
            }
        }
    }
}
