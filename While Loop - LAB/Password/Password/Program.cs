using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            if (input == password)
            {
                Console.WriteLine($"Welcome {username}!");
            }
            while (password != input)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                }
            }
        }
    }
}
