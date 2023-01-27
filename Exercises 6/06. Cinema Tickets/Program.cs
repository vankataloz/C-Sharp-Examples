using System;
using System.Data;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTicket = 0,
                kidTicket = 0,
                standartTicket = 0,
                totalTickets = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    break;
                }
                string movieName = command;
                int hallCapacity = int.Parse(Console.ReadLine());
                int soldTickets = 0;

                for(int i = 0; i < hallCapacity; i++)
                {
                    string ticketCommand = Console.ReadLine();

                    if(ticketCommand == "End")
                    {
                        break;
                    }
                    switch(ticketCommand)
                    {
                        case "standard": standartTicket++; break;
                        case "kid": kidTicket++; break;
                        case "student": studentTicket++; break;
                    }
                    totalTickets++;
                    soldTickets++;
                }
                Console.WriteLine($"{movieName} - {(soldTickets * 1.0 / hallCapacity)* 100:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTicket * 1.0 / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standartTicket * 1.0 / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTicket * 1.0 / totalTickets) * 100:f2}% kids tickets.");
        }
    }
}