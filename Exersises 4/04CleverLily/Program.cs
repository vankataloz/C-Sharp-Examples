using System;
namespace _04CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double collectedMoney = 0;
            int moneyToBeReceived = 10;

            for(int years = 1; years <= age; years++)
            {
                if(years % 2 == 0)
                {
                    collectedMoney += moneyToBeReceived;
                    moneyToBeReceived += 10;
                    collectedMoney--;
                }
                else
                {
                    collectedMoney += toyPrice;
                }
            }
            if (collectedMoney < washingMachinePrice)
            {
                Console.WriteLine($"No! {washingMachinePrice - collectedMoney:f2}");
            }
            else
                Console.WriteLine($"Yes! {collectedMoney - washingMachinePrice:f2}");
            
        }
    }
}