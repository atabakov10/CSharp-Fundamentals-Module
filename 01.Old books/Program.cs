using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int countBooks = 0;
            bool isFound = false;
            string currentBook = Console.ReadLine();

            while (currentBook != "No More Books")
            {
                if (currentBook == bookName)
                {
                    isFound = true;
                    break;
                }
                else
                {
                    countBooks++;
                }
                currentBook = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {countBooks} books and found it.");

            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBooks} books.");
            }
        }
    }
}
