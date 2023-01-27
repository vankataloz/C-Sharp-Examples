using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int penPack = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine()) / 100;

            //calculations
            double penPrice = penPack * 5.80;
            double markerPrice = marker * 7.20;
            double boardCleanerPrice = boardCleaner * 1.20;
            double price = penPrice + markerPrice + boardCleanerPrice;
            double totalPrice = price - (price * percentDiscount);

            //output
            Console.WriteLine(totalPrice);
        }
    }
}