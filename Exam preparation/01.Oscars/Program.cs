using System;
using System.Diagnostics;

namespace _01.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rentCost = int.Parse(Console.ReadLine());
            double figurineCost = rentCost * 0.7;
            double cateringCost = figurineCost * 0.85;
            double voicingCost = cateringCost * 0.5;
            double totalCeremonyCost = rentCost + figurineCost + cateringCost + voicingCost;


            Console.WriteLine($"{totalCeremonyCost:f2}");
        }
    }
}