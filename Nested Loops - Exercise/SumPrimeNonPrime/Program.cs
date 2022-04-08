using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int num = int.Parse(input);
                if (num > 0)
                {
                    sum += num;
                }
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        nonPrimeSum += num;
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            primeSum = sum - nonPrimeSum;
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
