using System;

namespace Ex._05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int startIndex = 0;
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                startIndex = str.ToLower().IndexOf("in", i);
                if (startIndex == i)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
