using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int stayTime = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0;
            stayTime -= 1;

            switch (roomType)
            {
                case "room for one person":
                    price = 18 * stayTime;
                    break;
                case "apartment":
                    price = 25 * stayTime;
                    if (stayTime < 10)
                    {
                        price -= price * 0.3;
                    }
                    else if (stayTime >= 10 && stayTime <= 15)
                    {
                        price -= price * 0.35;
                    }
                    else if (stayTime > 15)
                    {
                        price -= price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = 35 * stayTime;
                    if (stayTime < 10)
                    {
                        price -= price * 0.1;
                    }
                    else if (stayTime >= 10 && stayTime <= 15)
                    {
                        price -= price * 0.15;
                    }
                    else if (stayTime > 15)
                    {
                        price -= price * 0.2;
                    }
                    break;
            } 
            if (grade == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.1;
            }

            Console.WriteLine(price.ToString("0.00"));
        }
    }
}
