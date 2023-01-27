using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());

            int secondsSum = firstSeconds + secondSeconds + thirdSeconds;
            int minutes = secondsSum / 60;
            // int leftSeconds = secondSum % 60;
            int leftSeconds = secondsSum - (minutes * 60);
            if (leftSeconds < 10)
            {
                Console.WriteLine($"{minutes}:0{leftSeconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{leftSeconds}");
            }
        }
    }
}