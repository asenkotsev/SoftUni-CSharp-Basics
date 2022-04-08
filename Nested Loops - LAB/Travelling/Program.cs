using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double savedMoney = 0;
            while (input != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                while (savedMoney < neededMoney)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {input}!");
                savedMoney = 0;
                input = Console.ReadLine();
            }
        }
    }
}
