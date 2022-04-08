using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int plasticAmount = int.Parse(Console.ReadLine());
            int paintAmount = int.Parse(Console.ReadLine());
            int paintThinnerAmount = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());
            double plasticPrice = (plasticAmount + 2) * 1.5;
            double paintPrice = (paintAmount + paintAmount * 0.1) * 14.5;
            int paintThinnerPrice = paintThinnerAmount * 5;
            double materialCost = plasticPrice + paintPrice + paintThinnerPrice + 0.4;
            double workCostPerHour = materialCost * 0.3;
            double workCost = workCostPerHour * workHours;
            double finalPrice = materialCost + workCost;
            Console.WriteLine(finalPrice);
        }
    }
}
