using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0.0;
            string evenodd = "";

            
            if((n2==0 && op== "/") || (n2 == 0 && op == "%"))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (op =="/")
            {
                result = n1 / n2;

                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (op == "%")
            {
                result = n1 % n2;

                Console.WriteLine($"{n1} % {n2} = {result}");
            }
            else if (op == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    evenodd = "even";
                }
                else if (result % 2 != 0)
                {
                    evenodd = "odd";
                }
                Console.WriteLine($"{n1} - {n2} = {result} - {evenodd}");
            }
            else if (op == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    evenodd = "even";
                }
                else if (result % 2 != 0)
                {
                    evenodd = "odd";
                }
                Console.WriteLine($"{n1} + {n2} = {result} - {evenodd}");
            }
            else if (op == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    evenodd = "even";
                }
                else if (result % 2 != 0)
                {
                    evenodd = "odd";
                }
                Console.WriteLine($"{n1} * {n2} = {result} - {evenodd}");
            }
        }
    }
}