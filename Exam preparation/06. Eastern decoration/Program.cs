using System;
using System.Data;

namespace _06._Eastern_decoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clientsCount = int.Parse(Console.ReadLine());
            double totalCost = 0.0;
            int purchasesCount = 0;
            double allClientsCost = 0;

            for (int i = 0; i < clientsCount; i++)
            {
                string command = Console.ReadLine();
                purchasesCount = 0;
                totalCost = 0.0;
                while (command != "Finish")
                {
                    switch (command)
                    {
                        case "basket":
                            totalCost += 1.50;
                            purchasesCount++;
                            break;
                        case "wreath":
                            totalCost += 3.80;
                            purchasesCount++;
                            break;
                        case "chocolate bunny":
                            totalCost += 7;
                            purchasesCount++;
                            break;
                    }
                    command = Console.ReadLine();
                }
                if (purchasesCount % 2 == 0)
                {
                    totalCost *= 0.80;
                }

                Console.WriteLine($"You purchased {purchasesCount} items for {totalCost:F2} leva.");
                allClientsCost += totalCost;
            }
            Console.WriteLine($"Average bill per client is: {(allClientsCost / clientsCount):F2} leva.");
        }
    }
}