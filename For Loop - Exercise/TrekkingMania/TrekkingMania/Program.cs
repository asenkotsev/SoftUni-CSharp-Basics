using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;

            for (int i = 0; i < n; i++)
            {
                int group = int.Parse(Console.ReadLine());
                if (group <= 5)
                {
                    group1 += group;
                }
                else if (group >= 6 && group <= 12)
                {
                    group2 += group;
                }
                else if (group >= 13 && group <= 25)
                {
                    group3 += group;
                }
                else if (group >= 26 && group <= 40)
                {
                    group4 += group;
                }
                else if (group >= 41)
                {
                    group5 += group;
                }
            }

            double allPeople = group1 + group2 + group3 + group4 + group5;
            Console.WriteLine($"{(group1 / allPeople * 100).ToString("0.00")}%");
            Console.WriteLine($"{(group2 / allPeople * 100).ToString("0.00")}%");
            Console.WriteLine($"{(group3 / allPeople * 100).ToString("0.00")}%");
            Console.WriteLine($"{(group4 / allPeople * 100).ToString("0.00")}%");
            Console.WriteLine($"{(group5 / allPeople * 100).ToString("0.00")}%");

        }
    }
}
