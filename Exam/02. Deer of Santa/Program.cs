using System;
namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int missingDays = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodForOneDayFirstDeer = double.Parse(Console.ReadLine());
            double foodForOneDaySecondDeer = double.Parse(Console.ReadLine());
            double foodForOneDayThirdDeer = double.Parse(Console.ReadLine());

            double foodNeeded = (foodForOneDayFirstDeer + foodForOneDaySecondDeer + foodForOneDayThirdDeer) * missingDays;

            if(foodLeft >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodLeft-foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded- foodLeft)} more kilos of food are needed.");
                
            }

        }
    }
}