using System;
using System.Runtime.Serialization;

namespace _04EvenPowersof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int power = 0; power<=number; power++ )
            {
                if(power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, power));
                }
            }
        }
    }
}