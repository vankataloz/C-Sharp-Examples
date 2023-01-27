using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int Nylon = int.Parse(Console.ReadLine()) + 2;
            //to do add 10% more
            int paintInLitters = int.Parse(Console.ReadLine());
            //0.1 - 10% 
            //0.56 - 56%
            double paintInLittersBonus = paintInLitters + (paintInLitters * 0.1);
            //11 litters
            //10% ot 11 litra = 11 * 0.1 = 1.1 litra bonus
            // total littres = 11 + 1.1 bonus = 12.1
            int diluent = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());
            // calculations
            double NylonPrice = Nylon * 1.50;
            double paintPrice = paintInLittersBonus * 14.50;
            double diluentPrice = diluent * 5.0; // dont forget to multiply by at least one double da slojim .neshto
            double totalPriceForMatterials = NylonPrice + paintPrice + diluentPrice + 0.40;
            double workersPay = totalPriceForMatterials * 0.3 * workingHours;

            //output
            Console.WriteLine(totalPriceForMatterials + workersPay);
        }
    }
}