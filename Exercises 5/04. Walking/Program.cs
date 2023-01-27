using System;
namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int goalSteps = 10000;

            while (totalSteps<=goalSteps)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                   int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    break;
                }
                else
                {
                    int stepsWalked = int.Parse(command);
                    totalSteps += stepsWalked;
                }
            }
            if (totalSteps >= goalSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goalSteps} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goalSteps - totalSteps} more steps to reach goal.");
            }
        }
    }
}