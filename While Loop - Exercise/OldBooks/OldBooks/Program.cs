using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string input = Console.ReadLine();
            bool check = true;
            int index = 0;

            while (input != "No More Books")
            {
                if (favoriteBook == input)
                {
                    check = false;
                    break;
                }
                index++;
                input = Console.ReadLine();
            }

            if (check)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {index} books.");
            }
            else
            {
                Console.WriteLine($"You checked {index} books and found it.");

            }
        }
    }
}
 