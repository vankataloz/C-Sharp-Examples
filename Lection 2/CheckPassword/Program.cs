using System;

namespace CheckPassword // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (password == "s3cr3t!P@ssw0rd")
                Console.WriteLine("Welcome");
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}