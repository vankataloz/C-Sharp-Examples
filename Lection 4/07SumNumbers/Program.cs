using System;
namespace _07SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfnumbers = 0;

            for(int i = 1; i<=number; i++)
            {

                int currentNumber = int.Parse(Console.ReadLine());
                sumOfnumbers += currentNumber;

            }
            Console.WriteLine(sumOfnumbers);
        }
    }
}