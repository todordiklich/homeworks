using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main()
        {
            double neededExperiance = double.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine());
            double collectedExperiance = 0.0;

            for (int i = 1; i <= battleCount; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    experiencePerBattle *= 1.15;
                }
                if (i % 5 == 0)
                {
                    experiencePerBattle *= 0.90;
                }
                collectedExperiance += experiencePerBattle;
                if (collectedExperiance >= neededExperiance)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {(neededExperiance - collectedExperiance):F2} more needed.");
        }
    }
}
