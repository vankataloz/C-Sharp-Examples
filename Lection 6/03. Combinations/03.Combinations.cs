using System;
namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int resultsCount = 0;

            for (int firstMultiply = 0; firstMultiply <= number; firstMultiply++)
            {
                for (int secondMultiply = 0; secondMultiply <= number; secondMultiply++)
                {
                    for (int thirdMultiply = 0; thirdMultiply <= number; thirdMultiply++)
                    {
                        int result = firstMultiply + secondMultiply + thirdMultiply;
                        if (result == number)
                        {
                            resultsCount++;
                        }
                    }
                }
            }
            Console.WriteLine(resultsCount);
        }
    }
}