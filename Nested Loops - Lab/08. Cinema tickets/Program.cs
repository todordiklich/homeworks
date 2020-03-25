using System;

namespace _08._Cinema_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTicketCounter = 0;
            int standardCounter = 0;
            int studentCounter = 0;
            int kidCounter = 0;
            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                double freeSits = double.Parse(Console.ReadLine());
                int ticketCounter = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "standard")
                    {
                        ticketCounter++;
                        standardCounter++;
                        totalTicketCounter++;
                    }
                    else if (ticketType == "student")
                    {
                        ticketCounter++;
                        studentCounter++;
                        totalTicketCounter++;
                    }
                    else // kid
                    {
                        ticketCounter++;
                        kidCounter++;
                        totalTicketCounter++;
                    }
                    if (ticketCounter >= freeSits)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{movieName} - {((ticketCounter / freeSits) * 100):F2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTicketCounter}");
            Console.WriteLine($"{((studentCounter / totalTicketCounter) * 100):F2}% student tickets.");
            Console.WriteLine($"{((standardCounter / totalTicketCounter) * 100):F2}% standard tickets.");
            Console.WriteLine($"{((kidCounter / totalTicketCounter) * 100):F2}% kids tickets.");
        }
    }
}
