using System;
namespace _02._CapturingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturingTime = int.Parse(Console.ReadLine());
            int countScenes = int.Parse(Console.ReadLine());
            int timeScenes = int.Parse(Console.ReadLine());
            double preparation = picturingTime * 0.15;
            int totalTimeScenes = countScenes * timeScenes;

            double totalTime = preparation + totalTimeScenes;

            if (totalTime > preparation)
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(totalTime - picturingTime)} minutes.");
            }
            else
            {
                Console.WriteLine($"You managed to finish the movie on time. You have {Math.Round(picturingTime - totalTime)} minutes left!");
            }

        }
    }
}