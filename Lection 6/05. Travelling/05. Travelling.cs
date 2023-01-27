using System;
namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double vacationBudget = double.Parse(Console.ReadLine());
                double collectedSum = 0;

                while (collectedSum < vacationBudget)
                {
                    double collectedMoney = double.Parse(Console.ReadLine());
                    collectedSum += collectedMoney;
                }
                if (collectedSum >= vacationBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
                destination = Console.ReadLine();

            }
        }
    }
}