﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}