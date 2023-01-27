using System;
namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int cakeSize = widght * height;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }
                int takeNow = int.Parse(command);
                if(takeNow > cakeSize)
                { 
                    Console.WriteLine($"No more cake left! You need {takeNow - cakeSize} pieces more.");
                    break;
                }
                cakeSize -= takeNow;
                if (cakeSize==0)
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }
            }
        }
    }
}