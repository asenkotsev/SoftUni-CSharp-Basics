using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double decor = budget * 0.10;

            if(actors > 150)
            {
                clothesPrice -= clothesPrice * 0.1;
            }

            double actorsCost = actors * clothesPrice;
            double neededMoney = decor + actorsCost;

            if (neededMoney <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Round(budget - neededMoney, 2).ToString("0.00")} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Round(neededMoney - budget, 2).ToString("0.00")} leva more.");
            }
        }
    }
}
