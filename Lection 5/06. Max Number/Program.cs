using System;
using System.Diagnostics;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.MinValue;

            while(input != "Stop")
            {
                int inputAsNumber = int.Parse(input);
                if(inputAsNumber>number)
                {
                    number = inputAsNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(number);
        }
    }
}