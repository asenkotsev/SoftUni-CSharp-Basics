using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double nCount1 = 0;
            double nCount2 = 0;
            double nCount3 = 0;
            double nCount4 = 0;
            double nCount5 = 0;


            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a < 200)
                {
                    nCount1++;
                }
                else if (a >= 200 && a <= 399)
                {
                    nCount2++;
                }
                else if (a >= 400 && a <= 599)
                {
                    nCount3++;
                }
                else if (a >= 600 && a <= 799)
                {
                    nCount4++;
                }
                else if (a >= 800)
                {
                    nCount5++;
                }
            }

            Console.WriteLine($"{(nCount1 / n * 100).ToString("0.00")}%");
            Console.WriteLine($"{(nCount2 / n * 100).ToString("0.00")}%");
            Console.WriteLine($"{(nCount3 / n * 100).ToString("0.00")}%");
            Console.WriteLine($"{(nCount4 / n * 100).ToString("0.00")}%");
            Console.WriteLine($"{(nCount5 / n * 100).ToString("0.00")}%");
        }
    }
}
