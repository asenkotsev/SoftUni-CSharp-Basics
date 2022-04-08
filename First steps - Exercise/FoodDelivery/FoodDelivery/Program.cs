using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuAmount = int.Parse(Console.ReadLine());
            int fishMenuAmount = int.Parse(Console.ReadLine());
            int veggieMenuAmount = int.Parse(Console.ReadLine());
            double chickenMenuPrice = chickenMenuAmount * 10.35;
            double fishMenuPrice = fishMenuAmount * 12.40;
            double veggieMenuPrice = veggieMenuAmount * 8.15;
            double allMenuPrice = chickenMenuPrice + fishMenuPrice + veggieMenuPrice;
            double dessertPrice = allMenuPrice * 0.2;
            double finalPrice = allMenuPrice + dessertPrice + 2.5;
            Console.WriteLine(finalPrice);
        }
    }
}
