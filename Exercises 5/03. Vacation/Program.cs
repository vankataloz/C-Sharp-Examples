using System;
namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int daysSpend = 0;
            int totalDays = 0;

            while(true)
            {
                string command = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                if (command == "spend")
                {
                    daysSpend++;
                    money -= sum;
                    if (money < 0)
                    {
                        money = 0;
                    }
                }
                else
                {
                    daysSpend = 0;
                    money += sum;
                }
                totalDays++;

                if (money >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {totalDays} days.");
                    break;
                }
                if (daysSpend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{totalDays}");
                    break;
                }
            }
        }
    }
}