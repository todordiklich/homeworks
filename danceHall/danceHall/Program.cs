using System;

namespace danceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            // danceHall (rectengular) --> hallLenght [m]; hallWidth [m]
            // wardrobe (square) --> side A [m]
            // bench (rectangular) --> 10 times smaller than danceHall
            // dancer 40cm2 + 7000cm2
            // how many dancers in the hall (round down int)

            //imput
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            //logic
            double hallArea = ((hallLenght * 100) * (hallWidth * 100));
            double wardrobArea = ((wardrobeSide * 100) * (wardrobeSide * 100));
            double benchArea = hallArea / 10;
            double freeArea = hallArea - (wardrobArea + benchArea);
            double dancerSpace = 40 + 7000;
            double dancerNumber = freeArea / dancerSpace;

            //print
            Console.WriteLine($"{Math.Floor(dancerNumber)}");


        }
    }
}
