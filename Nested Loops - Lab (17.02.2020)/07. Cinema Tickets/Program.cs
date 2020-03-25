using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double allTickets = 0.0;
            int studentTotal = 0;
            int standardTotal = 0;
            int kidTotal = 0;
            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                double freeSits = double.Parse(Console.ReadLine());
                int studentTicket = 0;
                int standardTicket = 0;
                int kidTicket = 0;
                while (true)
                {
                    string ticket = Console.ReadLine();
                    if (ticket == "End")
                    {
                        break;
                    }
                    allTickets++;
                    if (ticket == "student")
                    {
                        studentTicket++;
                        studentTotal++;
                    }
                    else if (ticket == "standard")
                    {
                        standardTicket++;
                        standardTotal++;
                    }
                    else // kid
                    {
                        kidTicket++;
                        kidTotal++;
                    }
                    if (standardTicket + studentTicket + kidTicket == freeSits)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{movie} - {(((standardTicket + studentTicket + kidTicket) / freeSits) * 100):F2}% full.");
            }
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(studentTotal / allTickets * 100):F2}% student tickets.");
            Console.WriteLine($"{(standardTotal / allTickets * 100):F2}% standard tickets.");
            Console.WriteLine($"{(kidTotal / allTickets * 100):F2}% kids tickets.");

        }
    }
}
