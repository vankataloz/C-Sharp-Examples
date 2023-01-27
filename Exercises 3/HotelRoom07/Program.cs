using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleepsCount = int.Parse(Console.ReadLine());
            double apartmentCost = 0.0;
            double studioCost = 0.0;

            switch(month)
            {
                case "May":
                case "October":

                    if(sleepsCount > 7 && sleepsCount < 14)
                    {
                        studioCost = (sleepsCount * 50.00) * 0.95;
                        apartmentCost = sleepsCount * 65.00;
                    }
                    else if(sleepsCount > 14)
                    {
                        studioCost = (sleepsCount * 50.00) * 0.70;
                        apartmentCost = (sleepsCount * 65.00) * 0.90;
                    }
                    else
                    {
                        studioCost = sleepsCount * 50.00;
                        apartmentCost = sleepsCount * 65.00;
                    }
                    break;
                case "June":
                case "September":
                    if(sleepsCount > 14)
                    {
                        studioCost = (sleepsCount * 75.20) * 0.80;
                        apartmentCost = (sleepsCount * 68.70) * 0.90;
                    }
                    else
                    {
                        studioCost = sleepsCount * 75.20;
                        apartmentCost = sleepsCount * 68.70;
                    }
                    break;
                case "July":
                case "August":
                    if (sleepsCount > 14)
                    {
                        studioCost = sleepsCount * 76;
                        apartmentCost = (sleepsCount * 77) * 0.90;
                    }
                    else
                    {
                        studioCost = sleepsCount * 76;
                        apartmentCost = sleepsCount * 77;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {apartmentCost:f2} lv.");
            Console.WriteLine($"Studio: {studioCost:f2} lv.");
        }
    }
}