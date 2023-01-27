using System;

namespace _03._Excursion_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalCost = 0.0;

            switch (season)
            {
                case "spring":
                    if (persons <= 5)
                    {
                        totalCost = persons * 50.00;
                    }
                    else
                    {
                        totalCost = persons * 48.00;
                    }
                    break;
                case "summer":
                    if (persons <= 5)
                    {
                        totalCost = persons * 48.50;
                    }
                    else
                    {
                        totalCost = persons * 45.00;
                    }
                    totalCost *= 0.85;
                    break;
                case "autumn":
                    if (persons <= 5)
                    {
                        totalCost = persons * 60.00;
                    }
                    else
                    {
                        totalCost = persons * 49.50;
                    }
                    break;
                case "winter":
                    if (persons <= 5)
                    {
                        totalCost = persons * 86.00;
                    }
                    else
                    {
                        totalCost = persons * 85.00;
                    }
                    totalCost *= 1.08;
                    break;
            }

            Console.WriteLine($"{totalCost:f2} leva.");
        }
    }
}