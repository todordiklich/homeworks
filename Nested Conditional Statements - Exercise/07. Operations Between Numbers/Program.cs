using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0.0;
            string evenOdd = "";
            
            if (symbol == "+")
            {
                result = number1 + number2;
            }
            else if (symbol == "-")
            {
                result = number1 - number2;
            }
            else if (symbol == "*")
            {
                result = number1 * number2;
            }
            else if (symbol == "/")
            {
                if (number2 == 0)
                 {
                     Console.WriteLine($"Cannot divide {number1} by zero");
                 }
                 else
                 {
                     result = number1 / number2;
                 }
            }
            else if (symbol == "%")
            {
                if (number2 == 0)
                {
                     Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    result = number1 % number2;
                }
            }

            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                if (Math.Abs(result) % 2 == 0)
                {
                    evenOdd = "even";
                }
                else if (Math.Abs(result) % 2 == 1)
                {
                    evenOdd = "odd";
                }
                Console.WriteLine($"{number1} {symbol} {number2} = {result} - {evenOdd}");
            }
            else if (symbol == "/" && number2 !=0)
            {
                Console.WriteLine($"{number1} / {number2} = {result:f2}");
            }
            else if (symbol == "%" && number2 != 0)
            {
                Console.WriteLine($"{number1} % {number2} = {result}");
            }
        }
    }
}
