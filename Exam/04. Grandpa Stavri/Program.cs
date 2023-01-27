using System;
namespace _04._Grandpa_Stavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double quantity = 0;
            double degrees = 0;
            double totalQuantity = 0;
            double degreesSum = 0;
            double DegreesPerLiter = 0;
            double totalDegrees = 0;
            for (int i = 1; i <= days; i++)
            {
                quantity = double.Parse(Console.ReadLine());
                degrees = double.Parse(Console.ReadLine());
                degreesSum = quantity * degrees;
                totalQuantity += quantity;
                DegreesPerLiter += degreesSum;
            }
            totalDegrees = DegreesPerLiter / totalQuantity;
            Console.WriteLine("Liter: {0:f2}", totalQuantity);
            Console.WriteLine("Degrees: {0:f2}", totalDegrees);
            if (totalDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (totalDegrees >= 38 && totalDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (totalDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}