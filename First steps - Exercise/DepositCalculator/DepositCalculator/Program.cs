using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double intRate = double.Parse(Console.ReadLine());
            double interest = deposit * intRate / 100;
            double monthlyInterest = interest / 12;
            double balance = deposit += monthlyInterest * period;
            Console.WriteLine(balance);
        }
    }
}
