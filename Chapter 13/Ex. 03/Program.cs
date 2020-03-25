using System;

namespace Ex._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "((a+b)/5-d)";
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    counter++;
                }
                else if (str[i] == ')')
                {
                    counter--;
                }
            }
            int firstBracket = str.IndexOf("(");
            int secondBracket = str.IndexOf(")");
            if (firstBracket > secondBracket)
            {
                Console.WriteLine("Not Ok");
                return;
            }
            
            if (counter != 0)
            {
                Console.WriteLine("Not Ok");
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }
    }
}
