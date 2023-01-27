using System;
namespace _05Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabsCount = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            int moneyTaked = 0;
            for (int tabs = 0; tabs < tabsCount; tabs++)
            {
                string tabsName = Console.ReadLine();

                switch(tabsName)
                    {
                    case "Facebook":
                        moneyTaked += 150;
                        break;
                    case "Instagram":
                        moneyTaked += 100;
                        break;
                    case "Reddit":
                        moneyTaked += 50;
                        break;

                }
            }
            if(moneyTaked >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - moneyTaked);
            }
        }
    }
}