using System;

namespace _09._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commision = 0.0;

            if (town == "Sofia")
            {
                if (sales > 0 && sales <=500)
                {
                    commision = 5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 7;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 8;
                }
                else if (sales > 10000 )
                {
                    commision = 12;
                }
                

            }
            else if (town == "Varna")
            {
                if (sales > 0 && sales <= 500)
                {
                    commision = 4.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 7.5;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 10;
                }
                else if (sales > 10000)
                {
                    commision = 13;
                }
                

            }
            else if (town == "Plovdiv")
            {
                if (sales > 0 && sales <= 500)
                {
                    commision = 5.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = 8;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = 12;
                }
                else if (sales > 10000)
                {
                    commision = 14.5;
                }

            }
            
            double totalCommision = sales * (commision / 100);
            if (totalCommision > 0 && (town == "Sofia" || town == "Varna" || town == "Plovdiv"))
            {
                Console.WriteLine($"{totalCommision:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
