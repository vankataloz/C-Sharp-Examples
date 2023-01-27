using System;
namespace _05CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int textChars = 0; textChars < text.Length; textChars++)
            {
                char letter = text[textChars];
                Console.WriteLine(letter);
            }
        }
    }
}