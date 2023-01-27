using System;
using System.Data;

namespace _05._Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int gamePoints = 301;
            int succssesfulShots = 0;
            int unsuccessfulShots = 0;
            string command = Console.ReadLine();

            while (command !="Retire")
            {
                int points = int.Parse(Console.ReadLine());

                switch(command)
                {
                    case "Double":
                        {
                            points *= 2;
                            break;
                        }
                    case "Triple":
                        {
                            points *= 3;
                            break;
                        }
                        
                }
                if(points < gamePoints)
                {
                    gamePoints -= points;
                    succssesfulShots++;
                }
                else if (points == gamePoints)
                {
                    gamePoints -= points;
                    succssesfulShots++;
                    break;
                }
                else
                {
                    unsuccessfulShots++;
                }
                command = Console.ReadLine();
            }
            if(command=="Retire")
            {
                Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} won the leg with {succssesfulShots} shots.");
            }
        }
    }
}