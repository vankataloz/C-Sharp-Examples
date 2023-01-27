using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeNeededForOneMeterSwimming = double.Parse(Console.ReadLine());

            double secondsForWholeDistance = distance * timeNeededForOneMeterSwimming;
            double timesSlowDown = Math.Floor(distance / 15); // math reje sled . nadolu
            secondsForWholeDistance += timesSlowDown * 12.5;

            if (secondsForWholeDistance < currentRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {secondsForWholeDistance:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {secondsForWholeDistance - currentRecord:f2} seconds slower.");
            }

        }
    }
}