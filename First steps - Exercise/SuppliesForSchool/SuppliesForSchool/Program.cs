using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double detergentPrice = detergent * 1.20;
            double price = pensPrice + markersPrice + detergentPrice;
            double finalPrice = price -= price * discount / 100;
            Console.WriteLine(finalPrice);
        }
    }
}
