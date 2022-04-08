using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int savedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += 5 * i - 1;
                }
                else
                {
                    savedMoney += toyPrice;
                }
            }

            if (savedMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {(savedMoney - laundryPrice).ToString("0.00")}");
            } else
            {
                Console.WriteLine($"No! {(laundryPrice - savedMoney).ToString("0.00")}");

            }
        }
    }
}
