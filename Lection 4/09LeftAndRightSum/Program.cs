using System;
namespace _07SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < pairs * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < pairs)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}