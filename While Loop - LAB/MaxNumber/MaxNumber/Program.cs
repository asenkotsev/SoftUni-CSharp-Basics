using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.Parse(Console.ReadLine());

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (max < num)
                {
                    max = num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
