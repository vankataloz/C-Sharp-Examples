using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());


            for (int currentFloor = floors; currentFloor >= 1; currentFloor--)
            {
                string floorTemplate = "";

                for (int currentRoom = 0; currentRoom < rooms; currentRoom++)
                {
                    if (floors == currentFloor)
                    {
                        floorTemplate += $"L{currentFloor}{currentRoom} ";
                    }
                    else if (currentFloor % 2 == 0)
                    {
                        floorTemplate += $"O{currentFloor}{currentRoom} ";
                    }
                    else
                    {
                        floorTemplate += $"A{currentFloor}{currentRoom} ";
                    }
                }
                Console.WriteLine(floorTemplate);
            }
        }
    }
}