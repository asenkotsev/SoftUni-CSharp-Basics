using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpus = int.Parse(Console.ReadLine());
            int cpus = int.Parse(Console.ReadLine());
            int rams = int.Parse(Console.ReadLine());

            int gpuPrice = 250;
            double cpuPrice = gpuPrice * gpus * 0.35;
            double ramPrice = gpuPrice * gpus * 0.1;
            double totalPrice = gpuPrice * gpus + cpuPrice * cpus + ramPrice * rams;

            if (gpus > cpus)
            {
                totalPrice -= totalPrice * 0.15;
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"You have {(budget - totalPrice).ToString("0.00")} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalPrice - budget).ToString("0.00")} leva more!");
            }
        }
    }
}
