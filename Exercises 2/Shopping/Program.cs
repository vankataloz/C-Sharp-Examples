using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsCount = int.Parse(Console.ReadLine());
            int cpuCounts = int.Parse(Console.ReadLine());
            int memoriesCount = int.Parse(Console.ReadLine());

            double videoCardsTotalSum = videoCardsCount * 250;
            double cpuPrice = videoCardsTotalSum * 0.35;
            double memoriesPrice = videoCardsTotalSum * 0.10;
            double totalSum = videoCardsTotalSum + (cpuCounts * cpuPrice) + (memoriesCount * memoriesPrice);
            
            if (videoCardsCount > cpuCounts)
            {
                totalSum = totalSum * 0.85;
            }
            if(budget >= totalSum)
            {
             Console.WriteLine($"You have {(budget-totalSum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalSum-budget):f2} leva more!");
            }
        }
    }
}