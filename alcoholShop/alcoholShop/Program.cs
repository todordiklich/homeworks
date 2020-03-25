using System;

namespace alcoholShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input --> whiskeyPrice lv/l; quontity of: beer, wine, rakia & whiskey;
            //condition --> rakiaPrice = whiskeyPrice / 2 ; winePrice = 40% rakiaPrice ; beerPrice = 80% rakiaPrice ; 
            //task --> the money that are needed for the all alcohol :F2

            //input
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            //logic
            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice * (1 - 0.40);
            double beerPrice = rakiaPrice * (1 - 0.80);

            double whiskeyMoney = whiskey * whiskeyPrice;
            double rakiaMoney = rakia * rakiaPrice;
            double wineMoney = wine * winePrice;
            double beerMoney = beer * beerPrice;

            double totalMoney = whiskeyMoney + rakiaMoney + wineMoney + beerMoney;

            //print

            Console.WriteLine($"{totalMoney:F2}");


        }
    }
}
