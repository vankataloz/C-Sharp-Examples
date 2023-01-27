using System;
namespace _08CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfweek = Console.ReadLine();
            int priceTicket = 0;

            switch (dayOfweek)
            {
                case "Monday": 
                case "Tuesday":
                case "Friday": priceTicket = 12; Console.WriteLine(priceTicket); break;
                case "Wednesday":
                case "Thursday": priceTicket = 14; Console.WriteLine(priceTicket); break;
                case "Saturday":
                case "Sunday": priceTicket = 16; Console.WriteLine(priceTicket); break;
                
                    
            }
        }
    }
}