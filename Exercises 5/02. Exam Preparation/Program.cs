using System;
namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradesCount = 0;
            int examCount = 0;
            double examSum = 0;
            string examName = "";

            while(true)
            {
                string input = Console.ReadLine();

                if (input == "Enough")
                {
                    Console.WriteLine($"Average score: {(examSum / examCount):f2}");
                    Console.WriteLine($"Number of problems: {examCount}");
                    Console.WriteLine($"Last problem: {examName}");
                    break;
                } 
                examName = input;
                int examGrade = int.Parse(Console.ReadLine());
                examCount++;
                examSum+=examGrade;

           
                if (examGrade <= 4)
                {
                    badGradesCount++;
                }
                if (badGradesCount == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
                    break;
                }
            }
        }
    }
}