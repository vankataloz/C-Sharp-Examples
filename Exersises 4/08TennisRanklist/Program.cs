using System;
using System.Security.Principal;

namespace _08TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            double winPoints = 0.0;
            double percentWin = 0.0;

            for(int i = 0; i < tournamentCount; i++)
            {
                string tournamentPosition = Console.ReadLine();
                switch(tournamentPosition)
                    {
                    case "W":
                        winPoints += 2000;
                        percentWin++;
                        break;
                    case "F":
                        winPoints += 1200;
                        break;
                    case "SF":
                        winPoints += 720;
                        break;
                    }
            }
            Console.WriteLine($"Final points: {startingPoints + winPoints}");
            Console.WriteLine($"Average points: {Math.Floor(winPoints / tournamentCount)} ");
            Console.WriteLine($"{percentWin * 1.0 / tournamentCount * 100.0:f2}%");
        }
    }
}