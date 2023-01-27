using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int priceForWholeYear = int.Parse(Console.ReadLine());
            //calculations
            double shoesPrice = priceForWholeYear - (priceForWholeYear * 0.4);
            double jerseyPrice = shoesPrice - (shoesPrice * 0.2);
            double ballPrice = jerseyPrice / 4;
            double accessoriesPrice = ballPrice / 5;

            //output
            Console.WriteLine(shoesPrice + jerseyPrice + ballPrice + accessoriesPrice + priceForWholeYear);
        }
    }
}