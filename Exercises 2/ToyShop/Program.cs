using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double totalSum = ((puzzlesCount * 2.6) + (dollsCount * 3) + (bearsCount * 4.10) + (minionsCount) * 8.20 + (trucksCount * 2));
            int toysCount = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;

            if(toysCount >= 50)
            {
                totalSum = totalSum * 0.75; // otstupkata e 25% zatova vzemame 0.75 ot cenata
            }
            totalSum = totalSum * 0.9; // tuk vzemame 10% ot poluchenata suma za naem - pishem sled if-a za da vidim dali sa nad 50 igrachki za otstupka 25%

            if (totalSum >= tripCost)
            {
                Console.WriteLine($"Yes! {totalSum - tripCost:f2} lv left.");
            }
            else if (totalSum < tripCost)
                    {
                Console.WriteLine($"Not enough money! {tripCost - totalSum:f2} lv needed.");
            }
        }
    }
}