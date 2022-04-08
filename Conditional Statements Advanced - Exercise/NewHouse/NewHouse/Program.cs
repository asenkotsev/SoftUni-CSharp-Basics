using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowersAmount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (flower)
            {
                case "Roses":
                    if (flowersAmount > 80)
                    {
                        price = flowersAmount * 5 - (flowersAmount * 5) * 0.1;
                    }
                    else
                    {
                        price = flowersAmount * 5;
                    }
                    break;
                case "Dahlias":
                    if (flowersAmount > 90)
                    {
                        price = flowersAmount * 3.8 - (flowersAmount * 3.8) * 0.15;
                    }
                    else
                    {
                        price = flowersAmount * 3.8;
                    }
                    break;
                case "Tulips":
                    if (flowersAmount > 80)
                    {
                        price = flowersAmount * 2.8 - (flowersAmount * 2.8) * 0.15;
                    }
                    else
                    {
                        price = flowersAmount * 2.8;
                    }
                    break;
                case "Narcissus":
                    if (flowersAmount < 120)
                    {
                        price = flowersAmount * 3 + (flowersAmount * 3) * 0.15;
                    }
                    else
                    {
                        price = flowersAmount * 3;
                    }
                    break;
                case "Gladiolus":
                    if (flowersAmount < 80)
                    {
                        price = flowersAmount * 2.5 + (flowersAmount * 2.5) * 0.2;
                    }
                    else
                    {
                        price = flowersAmount * 2.5;
                    }
                    break;
            }

            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersAmount} {flower} and {(budget - price).ToString("0.00")} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget).ToString("0.00")} leva more.");
            }
        }
    }
}
