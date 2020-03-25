using System;

namespace _04._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTaxes = int.Parse(Console.ReadLine());
            double total = 0;
            while (numberOfTaxes > 0)
            {
                double tax = double.Parse(Console.ReadLine());
                
                if (tax < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {tax:f2}");
                total += tax;
                numberOfTaxes--;
            }
            
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
