using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfday = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                if (timeOfday == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfday == "Afternoon" || timeOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                if (timeOfday == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfday == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
                if (degrees >= 25)
                {
                    if (timeOfday == "Morning")
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (timeOfday == "Afternoon")
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    else if (timeOfday == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}