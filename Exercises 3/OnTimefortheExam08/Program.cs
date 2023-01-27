using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTotalMinutes = examHour * 60 + examMinutes;
            int arrivalTotalMinutes = arrivalHour * 60 + arrivalMinutes;


            if(arrivalTotalMinutes > examTotalMinutes)
            {
                Console.WriteLine("Late");
                int minutesDifference = arrivalTotalMinutes - examTotalMinutes;
                if (minutesDifference < 60)
                {
                    Console.WriteLine($"{minutesDifference} minutes after the start");
                }
                else
                {
                    int hours = minutesDifference / 60;
                    int minutes = minutesDifference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
            else if(arrivalTotalMinutes < examTotalMinutes - 30)
            {
                Console.WriteLine("Early");
                int minutesDifference = examTotalMinutes - arrivalTotalMinutes;
                if (minutesDifference < 60)
                {
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
                else
                {
                    int hours = minutesDifference / 60;
                    int minutes = minutesDifference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                int minutesDifference = examTotalMinutes - arrivalTotalMinutes;
                if (minutesDifference != 0)
                {
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
            }
        }
    }
}