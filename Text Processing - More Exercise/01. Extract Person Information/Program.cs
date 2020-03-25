using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                int startIndexName = text.IndexOf('@');
                int endIndexName = text.IndexOf('|');

                int startIndexAge = text.IndexOf('#');
                int endIndexAge = text.IndexOf('*');

                string name = text.Substring(startIndexName + 1, endIndexName - startIndexName - 1);
                string age = text.Substring(startIndexAge + 1, endIndexAge - startIndexAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
