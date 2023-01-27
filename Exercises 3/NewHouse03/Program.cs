using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalSum = 0.0;


            switch (typeFlowers)
            {
                case "Roses":
                    if (flowerCount > 80)
                    {
                        totalSum = (flowerCount * 5) * 0.9;
                    }
                    else
                    {
                        totalSum = flowerCount * 5;
                    }
                    break;
                case "Dahlias":
                    if (flowerCount > 90)
                    {
                        totalSum = (flowerCount * 3.8) * 0.85;
                    }
                    else
                    {
                        totalSum = flowerCount * 3.80;
                    }
                    break;
                case "Tulips":
                    if (flowerCount > 80)
                    {
                        totalSum = (flowerCount * 2.80) * 0.85;
                    }
                    else
                    {
                        totalSum = flowerCount * 2.80;
                    }
                    break;
                case "Narcissus":
                    if (flowerCount < 120)
                    {
                        totalSum = (flowerCount * 3) * 1.15;
                    }
                    else
                    {
                        totalSum = flowerCount * 3;
                    }
                    break;
        
                case "Gladiolus":
                    if (flowerCount < 80)
                    {
                        totalSum = (flowerCount * 2.50) * 1.20;
                    }
                    else
                    {
                        totalSum = flowerCount * 2.50;
                    }
                    break;

            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {typeFlowers} and {(budget - totalSum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalSum - budget):f2} leva more.");
            }
        }
    }
}