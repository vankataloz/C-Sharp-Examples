using System;

namespace vavedeniesharp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

                Console.WriteLine($"I am {name} and I am {age} years old.");
        }
    }
}