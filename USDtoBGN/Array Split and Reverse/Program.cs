using System;

namespace Array_Split_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string value = "The quick brown fox jumps over the lazy dog";
            string[] items = value.Split(' ');
            foreach (string item in items)
            {
                char[] valueArray = item.ToCharArray();
                Array.Reverse(valueArray);
                string result = new string(valueArray);
                Console.Write($"{result} ");
            }
            */

            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);
        }
    }
}
