using System;
namespace _02HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if(currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }

            }
            int sumWithoutMax = sum - maxNumber;

            if (sumWithoutMax == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMax}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sumWithoutMax)}");
            }
        }
    }
}