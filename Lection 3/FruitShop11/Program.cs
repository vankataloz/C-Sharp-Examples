using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalSum = 0.0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana": totalSum = quantity * 2.50; break;
                    case "apple": totalSum = quantity * 1.20; break;
                    case "orange": totalSum = quantity * 0.85; break;
                    case "grapefruit": totalSum = quantity * 1.45; break;
                    case "kiwi": totalSum = quantity * 2.70; break;
                    case "pineapple": totalSum = quantity * 5.50; break;
                    case "grapes": totalSum = quantity * 3.85; break;

                }

            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": totalSum = quantity * 2.70; break;
                    case "apple": totalSum = quantity * 1.25; break;
                    case "orange": totalSum = quantity * 0.90; break;
                    case "grapefruit": totalSum = quantity * 1.60; break;
                    case "kiwi": totalSum = quantity * 3.00; break;
                    case "pineapple": totalSum = quantity * 5.60; break;
                    case "grapes": totalSum = quantity * 4.20; break;
                }
            }
            if ((fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes") && (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday" || dayOfWeek == "Sunday"))
            {
                Console.WriteLine($"{totalSum:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}