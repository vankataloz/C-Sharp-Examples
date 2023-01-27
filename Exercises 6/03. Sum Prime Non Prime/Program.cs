using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int a = 0;
        int primeSum = 0;
        int notPrimeSum = 0;
        while (true)
        {
            string n = Console.ReadLine();
            if (n == "stop")
            {
                break;
            }
            if (int.Parse(n) < 0)
            {
                Console.WriteLine("Number is negative.");
                continue;
            }
            for (int i = 1; i <= int.Parse(n); i++)
            {
                if (int.Parse(n) % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                primeSum += int.Parse(n);
            }
            else
            {
                notPrimeSum += int.Parse(n);
            }
            a = 0;
        }
        Console.WriteLine("Sum of all prime numbers is: {0}", primeSum);
        Console.WriteLine("Sum of all non prime numbers is: {0}", notPrimeSum);
    }
}