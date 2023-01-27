using System;

namespace SpeedCheck // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int speed = int.Parse(Console.ReadLine());
            if (speed < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (speed >= 100 && speed <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (speed > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}