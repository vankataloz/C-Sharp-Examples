using System;
namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int monetsCount = 0;

            while (change > 0)
            {
                if(change >= 2)
                {
                    monetsCount++;
                    change -= 2;
                }
                else if (change >= 1)
                {
                    monetsCount++;
                    change -= 1;
                }
                else if (change >= 0.5m)
                {
                    monetsCount++;
                    change -= 0.5m;
                }
                else if (change >= 0.2m)
                {
                    monetsCount++;
                    change -= 0.2m;
                }
                else if (change >= 0.1m)
                {
                    monetsCount++;
                    change -= 0.1m;
                }
                else if (change >= 0.05m)
                {
                    monetsCount++;
                    change -= 0.05m;
                }
                else if (change >= 0.02m)
                {
                    monetsCount++;
                    change -= 0.02m;
                }
                else if (change >= 0.01m)
                {
                    monetsCount++;
                    change -= 0.01m;
                }
            }
            Console.WriteLine(monetsCount);
        }
    }
}