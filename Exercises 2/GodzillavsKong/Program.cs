using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extrasCount = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double clothingSum = extrasCount * clothingPrice;

            if(extrasCount >= 150)
            {
                clothingSum = clothingSum * 0.90;
            }
            double totalMovieExpenses = decorPrice + clothingSum;

            if(budget-totalMovieExpenses < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalMovieExpenses - budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - totalMovieExpenses):f2} leva left."
);
            }
        }
    }
}