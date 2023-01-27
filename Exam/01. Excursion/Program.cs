using System;
namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            int cardsTransport = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            int nightPerPerson = nightsCount * 20;
            double sumCardsTransport = cardsTransport * 1.60;
            double sumMuseumTickets = museumTickets * 6;

            double totalSumPerPerson = nightPerPerson + sumCardsTransport + sumMuseumTickets;
            double groupTotalSum = totalSumPerPerson * peopleCount;
            double priceAfterExpensesPercent = groupTotalSum * 1.25;

            Console.WriteLine($"{priceAfterExpensesPercent:f2}");
        }
    }
}