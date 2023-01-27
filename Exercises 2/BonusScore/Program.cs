using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if(startingPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if(startingPoints <= 1000)  //pishem go taka zashtoto intervala tuk e ot 101 do 1000
            {
                bonusPoints = startingPoints * 0.2;
            }
            else
            {
                bonusPoints = startingPoints * 0.1;
            }
            //if(startingPoints <= 1000)
            // {

            // }
            bool isNumberEven = startingPoints % 2 == 0;
            if (isNumberEven)
            {
                bonusPoints = bonusPoints + 1; //Parvi variant
               // bonusPoints += 1;    // Vtori variant
               // bonusPoints++; //treti variant samo za 1
            }
            bool numberEndsWithFive = startingPoints % 10 == 5;
            if (numberEndsWithFive)
            {
                bonusPoints = bonusPoints + 2;
            }

                Console.WriteLine(bonusPoints);
                Console.WriteLine(bonusPoints + startingPoints);
        }
    }
}