using System;
using System.Collections.Generic;

namespace _00._Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }
            int[][] data ={new int[] { 45, 12 },
                           new int[] { 55, 21 },
                           new int[] { 19, 2 },
                           new int[] { 104, 20 }};
            
            List<string> title = new List<string>();
            foreach (int[] item in data)
            {

                if (item[0] >= 55 && item[1] > 7)
                {
                    title.Add("Senior");
                }
                else
                {
                    title.Add("Open");
                }
            }
            foreach (var item in title)
            {
                Console.Write(item + " ");
            }
        }
    }
}
