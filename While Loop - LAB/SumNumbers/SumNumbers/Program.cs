using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            while (sum < number)
            {
                sum += int.Parse(Console.ReadLine()); ;
            }

            Console.WriteLine(sum);
        }
    }
}
