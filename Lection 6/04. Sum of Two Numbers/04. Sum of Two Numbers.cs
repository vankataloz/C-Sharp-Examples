using System;
namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationCount = 0;
            int result = 0;
            bool isValidCombination = false;


            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    combinationCount++;
                    result = i + j;
                    if (result == magicNumber)
                    {
                        isValidCombination = true;
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }
                if (isValidCombination)
                {
                    break;
                }
            }
            if (!isValidCombination)
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}