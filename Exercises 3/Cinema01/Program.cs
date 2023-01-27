using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int columnsNumber = int.Parse(Console.ReadLine());
            int rowsNumber = int.Parse(Console.ReadLine());
            double totalSum = 0.0;

         //   if (typeProjection == "Premiere")
         //   {
          //      totalSum = columnsNumber * rowsNumber * 12.00;
          //  }
         //   else if (typeProjection == "Normal")
          //  {
          //      totalSum = columnsNumber * rowsNumber * 7.50;
          //  }
          //  else if (typeProjection == "Discount")
          //  {
         //       totalSum = columnsNumber * rowsNumber * 5.00;
          //  }

          //  Console.WriteLine($"{totalSum:f2} leva");

            switch (typeProjection)
            {
                case "Premiere": totalSum = ((columnsNumber * rowsNumber) * 12.00); break;
                case "Normal": totalSum = ((columnsNumber * rowsNumber) * 7.50); break;
               case "Discount": totalSum = ((columnsNumber * rowsNumber) * 5.00); break;
            }

            Console.WriteLine($"{totalSum:f2} leva");
        }
    }
}