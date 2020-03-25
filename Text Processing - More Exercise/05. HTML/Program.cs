using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string contend = Console.ReadLine();
            string comments = "";
            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }
                comments += comment + "|";
            }
            string[] commentsArray = comments.Split('|', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"<h1>\n    {title}\n</h1>\n<article>\n    {contend}\n</article>");
            foreach (var item in commentsArray)
            {
                Console.WriteLine($"<div>\n    {item}\n</div>");
            }
        }
    }
}
