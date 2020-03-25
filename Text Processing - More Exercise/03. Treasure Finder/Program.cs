using System;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string text = Console.ReadLine();
                string decriptedText = "";
                if (text == "find")
                {
                    break;
                }
                int counter = 0;
                foreach (var ch in text)
                {
                    decriptedText += (char)(ch - keys[counter]);
                    counter++;
                    if (counter == keys.Length)
                    {
                        counter = 0;
                    }
                }
                int startIndexType = decriptedText.IndexOf('&');
                int endIndexType = decriptedText.LastIndexOf('&');
                int startIndexCoordinates = decriptedText.IndexOf('<');
                int endIndexCoordinates = decriptedText.IndexOf('>');

                string type = decriptedText.Substring(startIndexType + 1, endIndexType - startIndexType - 1);
                string coordinates = decriptedText.Substring(startIndexCoordinates + 1, endIndexCoordinates - startIndexCoordinates - 1);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
