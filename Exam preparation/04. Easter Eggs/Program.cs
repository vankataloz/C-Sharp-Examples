using System;
namespace _04._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());
            int redColor = 0, orangeColor = 0, blueColor = 0, greenColor = 0;
            string ColorOfMaxEggs = "";
            int maxEggs = int.MinValue;
            for (int i = 1; i <= eggsCount; i++)
            {
                string eggColor = Console.ReadLine();

                if(eggColor == "red")
                {
                    redColor++;
                    if (redColor > maxEggs)
                    {
                        maxEggs = redColor;
                        ColorOfMaxEggs = "red";
                    }
                }
                else if (eggColor == "orange")
                {
                    orangeColor++;
                    if (orangeColor > maxEggs)
                    {
                        maxEggs = orangeColor;
                        ColorOfMaxEggs = "orange";
                    }
                }
                else if (eggColor == "blue")
                {
                    blueColor++;
                    if (blueColor > maxEggs)
                    {
                        maxEggs = blueColor;
                        ColorOfMaxEggs = "blue";
                    }
                }
                else if (eggColor == "green")
                {
                    greenColor++;
                    if (greenColor > maxEggs)
                    {
                        maxEggs = greenColor;
                        ColorOfMaxEggs = "green";
                    }
                }
            }
            Console.WriteLine($"Red eggs: {redColor}");
            Console.WriteLine($"Orange eggs: {orangeColor}");
            Console.WriteLine($"Blue eggs: {blueColor}");
            Console.WriteLine($"Green eggs: {greenColor}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {ColorOfMaxEggs}");
        }
    }
}