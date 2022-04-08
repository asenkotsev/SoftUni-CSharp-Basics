using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleAmount = int.Parse(Console.ReadLine());
            int dollAmount = int.Parse(Console.ReadLine());
            int teddyBearAmount = int.Parse(Console.ReadLine());
            int minionAmount = int.Parse(Console.ReadLine());
            int truckAmount = int.Parse(Console.ReadLine());

            int totalToyAmount = puzzleAmount + dollAmount + teddyBearAmount + minionAmount + truckAmount;
            double puzzlePrice = puzzleAmount * 2.6;
            int dollPrice = dollAmount * 3;
            double teddyBearPrice = teddyBearAmount * 4.1;
            double minionPrice = minionAmount * 8.2;
            int truckPrice = truckAmount * 2;
            double totalPrice = puzzlePrice + dollPrice + teddyBearPrice + minionPrice + truckPrice;

            if (totalToyAmount >= 50)
            {
                totalPrice -= totalPrice * 0.25;
            }
            double money = totalPrice - totalPrice * 0.1;

            if (money >= tripPrice)
            {
                Console.WriteLine($"Yes! {Math.Round(money - tripPrice, 2).ToString("0.00")} lv left.");
            }
            else
            {
                Console.Write($"Not enough money! {Math.Round(tripPrice - money, 2).ToString("0.00")} lv needed.");
            }
        }
    }
}
