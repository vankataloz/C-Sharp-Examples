using System;
namespace _12TradeCommissions

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double quantitySales = double.Parse(Console.ReadLine());
            double totalCommission = 0;

            if (quantitySales >= 0 && quantitySales <= 500)
            {
                switch (city)
                {
                    case "Sofia": totalCommission = quantitySales * 0.05; break;
                    case "Varna": totalCommission = quantitySales * 0.045; break;
                    case "Plovdiv": totalCommission = quantitySales * 0.055; break;
                }
            }
            else if (quantitySales > 500 && quantitySales <= 1000)
            {
                switch (city)
                {
                    case "Sofia": totalCommission = quantitySales * 0.07; break;
                    case "Varna": totalCommission = quantitySales * 0.075; break;
                    case "Plovdiv": totalCommission = quantitySales * 0.08; break;
                }
            }
            else if (quantitySales > 1000 && quantitySales <= 10000)
            {
                switch (city)
                {
                    case "Sofia": totalCommission = quantitySales * 0.08; break;
                    case "Varna": totalCommission = quantitySales * 0.10; break;
                    case "Plovdiv": totalCommission = quantitySales * 0.12; break;
                }
            }
            else if (quantitySales > 10000)
            {
                switch (city)
                {
                    case "Sofia": totalCommission = quantitySales * 0.12; break;
                    case "Varna": totalCommission = quantitySales * 0.13; break;
                    case "Plovdiv": totalCommission = quantitySales * 0.145; break;
                }
                
            }
            if (quantitySales > 0 && (city == "Sofia" || city == "Varna" || city == "Plovdiv"))
            {
                Console.WriteLine($"{totalCommission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}