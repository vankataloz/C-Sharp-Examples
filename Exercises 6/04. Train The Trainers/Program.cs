using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int judges = int.Parse(Console.ReadLine());
        double totalScore = 0;
        double finalScore = 0;
        int finalCount = 0;
        while (true)
        {
            string name = Console.ReadLine();
            if (name == "Finish")
            {
                break;
            }
            for (int i = 0; i < judges; i++)
            {
                double temp = double.Parse(Console.ReadLine());
                totalScore += temp;
                finalScore += temp;
            }
            Console.WriteLine("{0} - {1:f2}.", name, totalScore / judges);
            finalCount += judges;
            totalScore = 0;
        }
        Console.WriteLine("Student's final assessment is {0:f2}.", finalScore / finalCount);
    }
}