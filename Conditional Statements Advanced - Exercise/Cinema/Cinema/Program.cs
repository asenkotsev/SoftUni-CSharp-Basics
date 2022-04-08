using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double income = 0.0;

            if (projectionType == "Premiere")
            {
                income = rows * cols * 12;
            } else if (projectionType == "Normal")
            {
                income = rows * cols * 7.5;
            } else if (projectionType == "Discount")
            {
                income = rows * cols * 5;
            }

            Console.WriteLine($"{income.ToString("0.00")} leva");

        }
    }
}
