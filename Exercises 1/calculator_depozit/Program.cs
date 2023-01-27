using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double depositSum = double.Parse(Console.ReadLine());
            int depositInMonths = int.Parse(Console.ReadLine());
            double yearlyInterestPercent = double.Parse(Console.ReadLine());
            //calculations 
            
            double yearlyAccumulatedInterest = depositSum * yearlyInterestPercent / 100;
            double monthlyAccumulatedInterest = yearlyAccumulatedInterest / 12;
            double totalSum = depositSum + depositInMonths * monthlyAccumulatedInterest;
           // double totalSum = depositSum + depositInMonths * ((depositSum * yearlyInterestPercent / 100) / 12);
            //output  Ctrl + K + C all comment Ctrl + K + U all uncomment
            Console.WriteLine(totalSum);
        }
    }
}