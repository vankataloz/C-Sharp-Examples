using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            if (hours > 23)
            {
                hours = 23;
            }
            int minutes = int.Parse(Console.ReadLine());
            if (minutes > 59)
            {
                minutes = 59;
            }
            minutes += 15;
            if(minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            if(hours == 24)
            {
                hours = 0;
            }
            if(minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}