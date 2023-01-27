using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double moneySpend = 0.0;
            string type = "";
            switch (season)
            {
                case "summer":
                    type = "Camp";
                    if(budget <= 100)
                    {
                        destination = "Bulgaria";
                        moneySpend = budget * 0.3;
                    }
                    else if(budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        moneySpend = budget * 0.4;
                    }
                    else if(budget > 1000)
                    {
                        destination = "Europe";
                        moneySpend = budget * 0.9;
                        type = "Hotel";
                    }
                        break;
                case "winter":
                    type = "Hotel";
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        moneySpend = budget * 0.7;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        moneySpend = budget * 0.8;
                    }
                    else if (budget > 1000)
                    {
                        destination = "Europe";
                        moneySpend = budget * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {moneySpend:f2}");
        }
    }
}