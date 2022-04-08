using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()) * 100;
            int coinAmount = 0;

            while(Math.Truncate(change) > 0)
            {
                if(change >= 200)
                {
                    change -= 200;
                    coinAmount++;
                } else if (change >= 100)
                {
                    change -= 100;
                    coinAmount++;
                } else if (change >= 50)
                {
                    change -= 50;
                    coinAmount++;
                } else if (change >= 20)
                {
                    change -= 20;
                    coinAmount++;
                } else if (change >= 10)
                {
                    change -= 10;
                    coinAmount++;
                } else if (change >= 5)
                {
                    change -= 5;
                    coinAmount++;
                } else if (change >= 2)
                {
                    change -= 2;
                    coinAmount++;
                } else if (change >= 1)
                {
                    change -= 1;
                    coinAmount++;
                }
            }
            Console.WriteLine(coinAmount);
        }
    }
}
