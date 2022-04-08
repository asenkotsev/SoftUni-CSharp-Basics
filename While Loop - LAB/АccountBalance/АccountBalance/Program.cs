using System;

namespace АccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;

            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    balance += money;
                    Console.WriteLine($"Increase: {money.ToString("0.00")}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance.ToString("0.00")}");
        }
    }
}
