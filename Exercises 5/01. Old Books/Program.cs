﻿using System;
namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int bookCount = 0;

            while(searchedBook != "No More Books")
            {
                string input = Console.ReadLine();
                if (input == searchedBook)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }
                else if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                    break;
                }
                bookCount++;
            }

        }
    }
}