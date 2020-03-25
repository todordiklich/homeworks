using System;

namespace _06._Name_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestSum = 0;
            string biggestName = "";
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "STOP")
                {
                    break;
                }
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    char letter = name[i];
                    int value = letter;
                    sum += value;
                    if (biggestSum <= sum)
                    {
                        biggestName = name;
                        biggestSum = sum;
                    }
                }
            }
            Console.WriteLine($"Winner is {biggestName} – {biggestSum}!");
        }
    }
}
