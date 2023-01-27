using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeLenght = int.Parse(Console.ReadLine());
            int wholeRestLenght = int.Parse(Console.ReadLine());

            double lunchBreakLenght = wholeRestLenght / 8.0;
            double restLenght = wholeRestLenght / 4.0;
            double remainingTime = wholeRestLenght - (lunchBreakLenght + restLenght);

            if(remainingTime >=episodeLenght)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime - episodeLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLenght - remainingTime)} more minutes.");

            }
        }
    }
}