using System;
 
namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int floorNumber = floors;

            for (int currentFloor = 1; currentFloor <= floors; currentFloor++)
            {
                string floorTemplate = "";
                for (int currentRoom = 0; currentRoom < rooms; currentRoom++)
                {
                    if (currentFloor == 1)
                    {
                        floorTemplate += $"L{floorNumber}{currentRoom} ";
                    }
                    else if (currentFloor % 2 == 0)
                    {
                        floorTemplate += $"A{floorNumber}{currentRoom} ";
                    }
                    else
                    {
                        floorTemplate += $"O{floorNumber}{currentRoom} ";
                    }

                }
                floorNumber--;

                Console.WriteLine(floorTemplate);
            }
        }
    }
}