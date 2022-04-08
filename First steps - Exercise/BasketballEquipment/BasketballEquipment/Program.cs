using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double basketballSneakers = yearTax - yearTax * 0.4;
            double basketballOutfit = basketballSneakers - basketballSneakers * 0.2;
            double basketball = basketballOutfit / 4;
            double basketballAccessories = basketball / 5;
            double finalPrice = yearTax + basketballSneakers + basketballOutfit + basketball + basketballAccessories;
            Console.WriteLine(finalPrice);
        }
    }
}
