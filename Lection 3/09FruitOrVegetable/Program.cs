using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string productName = Console.ReadLine();

            switch (productName)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":Console.WriteLine("fruit");break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":Console.WriteLine("vegetable");break;
                default:Console.WriteLine("unknown");break;
            }

        }
    }
}