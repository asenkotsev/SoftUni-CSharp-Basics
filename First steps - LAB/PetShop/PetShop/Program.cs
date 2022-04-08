using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());
            double price = dogs * 2.5 + otherAnimals * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
}
