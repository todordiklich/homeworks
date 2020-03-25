using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            // input --> speed
            // speed <= 10 --> slow
            // 10 > speed <= 50 --> average
            // 50 > speed <= 150 --> fast
            //150 > speed <= 1000 --> very fast
            // speed > 1000 --> extremely fast

            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("very fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
