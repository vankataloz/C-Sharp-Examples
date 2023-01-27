using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherCount = int.Parse(Console.ReadLine());
            double boatPrice = 0.0;

            switch(season)
            {
                case "Spring": boatPrice = 3000; break;
                case "Winter": boatPrice = 2600; break;
                case "Summer": 
                case "Autumn":
                default: boatPrice = 4200; break;

            }
            if (fisherCount <= 6)
            {
                boatPrice = boatPrice * 0.9;
            }
            else if (fisherCount >= 7 && fisherCount <= 11)
            {
                boatPrice = boatPrice * 0.85;
            }
            else if (fisherCount >= 12)
            {
                boatPrice = boatPrice * 0.75;
            }
            if (fisherCount % 2 == 0 && season != "Autumn")
            {
                boatPrice = boatPrice * 0.95;
            }
            if (budget >= boatPrice)
            {
                Console.WriteLine($"Yes! You have {(budget - boatPrice):f2} leva left.");

            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(boatPrice-budget):f2} leva.");

            }
        }
    }
}