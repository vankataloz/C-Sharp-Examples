using System;
namespace _03Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0;
            int totalMembers = 0;
            for (int group = 0; group < groupCount; group++)
            {
                int groupMembers = int.Parse(Console.ReadLine());
                totalMembers += groupMembers;
                if (groupMembers <= 5)
                {
                    g1+= groupMembers;
                }
                else if (groupMembers <= 12)
                {
                    g2 += groupMembers;
                }
                else if (groupMembers <= 25)
                {
                    g3 += groupMembers;
                }
                else if (groupMembers <= 40)
                {
                    g4 += groupMembers;
                }
                else if (groupMembers >= 41)
                {
                    g5 += groupMembers;
                }
            }
            Console.WriteLine($"{g1 * 1.0 / totalMembers * 100.0:f2}%");
            Console.WriteLine($"{g2 * 1.0 / totalMembers * 100.0:f2}%");
            Console.WriteLine($"{g3 * 1.0 / totalMembers * 100.0:f2}%");
            Console.WriteLine($"{g4 * 1.0 / totalMembers * 100.0:f2}%");
            Console.WriteLine($"{g5 * 1.0 / totalMembers * 100.0:f2}%");
        }
    }
}