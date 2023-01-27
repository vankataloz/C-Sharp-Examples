using System;

namespace vavedeniesharp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double rate = 1.79549;
            double leva = dollars * rate;
        Console.WriteLine(leva);
        }
    }
}