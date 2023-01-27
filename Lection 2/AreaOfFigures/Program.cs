using System;

namespace SpeedInfo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double result = a * a;
                Console.WriteLine($"{result:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double result = a * b;
                Console.WriteLine($"{result:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double result = Math.PI * r * r;
                Console.WriteLine($"{result:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double result = (a * ha) / 2;
                Console.WriteLine($"{result:f3}");
            }
        }
    }
}