using System;
namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberToPrintInRow = 1;
            int currentNumber = 0;

            while (currentNumber < number)
            {
                for (int i = 0; i < numberToPrintInRow; i++)
                {
                    currentNumber++;
                    Console.Write(currentNumber + " ");

                    if(currentNumber >= number)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                numberToPrintInRow++;
            }
        }
    }
}