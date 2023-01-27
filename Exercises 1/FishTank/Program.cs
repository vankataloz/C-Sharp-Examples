using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int lenght = int.Parse(Console.ReadLine());
            int widght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            //calculations
            int volume = lenght * widght * height;
            double volumeLitters = volume / 1000.0;
            double percentageDevidedByHundred = percent / 100;
            double takedCappacity = volumeLitters * percentageDevidedByHundred;

            //output
            Console.WriteLine(volumeLitters - takedCappacity);
        }
    }
}