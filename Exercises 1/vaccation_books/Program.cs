using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pagesReadForOneHour = int.Parse(Console.ReadLine());
            int daysToReadTheBook = int.Parse(Console.ReadLine());
            //calculations
            int hoursToReadTheBook = pagesCount / pagesReadForOneHour;
            int daysRequiedToReadTheBook = hoursToReadTheBook / daysToReadTheBook;
            //output

            Console.WriteLine(daysRequiedToReadTheBook);
        }
    }
}