using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.Parse(Console.ReadLine());

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (min > num)
                {
                    min = num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
