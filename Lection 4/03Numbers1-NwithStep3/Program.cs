using System;
namespace _03Numbers1_NwithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            for (int i = 1; i <=number; i+=3)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}