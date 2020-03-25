using System;

namespace TryParse_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            double result = 0;
            double sum = 0;
            string resultText = "";
            foreach (string element in values)
            {
                if (double.TryParse(element, out result))
                {
                    sum += result;
                }
                else
                {
                    resultText +=  element;
                }
            }
            Console.WriteLine($"Message: {resultText}");
            Console.WriteLine($"Total: {sum}");
        }
    }
}
