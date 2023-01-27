using System;
namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int badGradesCount = 0;
            double gradesSum = 0.0;

            while(grade<=12)
            {
             double grades = double.Parse(Console.ReadLine());
                if (grades<4)
                {
                    badGradesCount++;
                }
                if (badGradesCount == 2)
                {
                    grade--;
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }
                else
                {
                    gradesSum += grades;
                    grade++;

                }
            }
            if (badGradesCount < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(gradesSum / 12):f2}");
            }
        }
    }
}