using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            double vacationCost = 0.0;

            int nights = days - 1;

            switch(type)
            {
                case "room for one person":
                   vacationCost = (nights * 18.00);
                    break;

                case "apartment":
                    if(days < 10)
                    {
                        vacationCost = ((nights * 25.00) * 0.70);
                    }
                    else if (days > 10 && days < 15)
                    {
                        vacationCost = ((nights * 25.00) * 0.65);
                    }
                    else
                    {
                        vacationCost = ((nights * 25.00) * 0.50);
                    }
                    break;

                case "president apartment":
                    if (days < 10)
                    {
                        vacationCost = ((nights * 35.00) * 0.90);
                    }
                    else if (days > 10 && days < 15)
                    {
                        vacationCost = ((nights * 35.00) * 0.85);
                    }
                    else
                    {
                        vacationCost = ((nights * 35.00) * 0.80);
                    }
                    break;
            }
            if (grade == "positive")
            {
                vacationCost *= 1.25;
            }
            else if (grade == "negative")
            {
                vacationCost  *= 0.90;
            }


            Console.WriteLine($"{vacationCost:f2}");
            
        }
    }
}