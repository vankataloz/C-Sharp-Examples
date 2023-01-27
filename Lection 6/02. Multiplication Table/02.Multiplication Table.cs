using System;
namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int firstMultiply = 1; firstMultiply <= 10; firstMultiply++)
            {
                for (int secondMultiply = 1; secondMultiply <= 10; secondMultiply++)
                {
                    Console.WriteLine($"{firstMultiply} * {secondMultiply} = {firstMultiply * secondMultiply}");
                }
            }
        }
    }
}