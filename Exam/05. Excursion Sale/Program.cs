using System;
namespace _05._Excursion_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double seaPrice = 680;
            double mountainPrice = 499;

            int seaExcursionCount = int.Parse(Console.ReadLine());
            int moutainExcursionCount = int.Parse(Console.ReadLine());

            double profit = 0;

            while (true)
            {
                string packetType = Console.ReadLine();

                if(packetType == "Stop")
                {
                    break;
                }
                if (packetType == "sea" && seaExcursionCount !=0)
                {
                    profit += seaPrice;
                    seaExcursionCount--;
                    if (seaExcursionCount < 0)
                    {
                        seaExcursionCount = 0;
                    }
                }
                else if (packetType == "mountain" && moutainExcursionCount !=0)
                {
                    profit += mountainPrice;
                    moutainExcursionCount--;
                    if(moutainExcursionCount <0)
                    {
                        moutainExcursionCount = 0;
                    }
                }
                if (seaExcursionCount == 0 && moutainExcursionCount == 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
            }

            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}