using System;
namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = height * width * length;

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Done")
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                    break;
                }

                int box = int.Parse(command);

                if(volume<box)
                {
                    Console.WriteLine($"No more free space! You need {box-volume} Cubic meters more.");
                    break;
                }
                volume -= box;
                if (volume == 0)
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                    break;
                }
            }

        }
    }
}