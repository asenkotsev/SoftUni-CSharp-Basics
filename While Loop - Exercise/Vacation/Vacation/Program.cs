using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int counter = 0;
            int days = 0;

            while (ownedMoney < neededMoney && counter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (action == "spend")
                {
                    if (ownedMoney - money < 0)
                    {
                        ownedMoney = 0;
                    }
                    else
                    {
                        ownedMoney -= money;
                    }
                    counter++;
                }
                else
                {
                    ownedMoney += money;
                    counter = 0;
                }
            }
            if (counter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
