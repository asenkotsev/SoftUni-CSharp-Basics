using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (max < a)
                {
                    max = a;
                }

                sum += a;
            }

            sum -= max;

            if(sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            } else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max)}");
            }
        }
    }
}
