using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int chickenMeal = int.Parse(Console.ReadLine());
            int fishMeal = int.Parse(Console.ReadLine());
            int veganMeal = int.Parse(Console.ReadLine());

            //calculations
            double totalChicken = chickenMeal * 10.35;
            double totalFish = fishMeal * 12.40;
            double totalVegan = veganMeal * 8.15;
            double dessert = (totalChicken + totalFish + totalVegan) * 0.20;
            double totalSum = totalChicken + totalFish + totalVegan + dessert + 2.50;
            //output
            Console.WriteLine(totalSum);
        }
    }
}