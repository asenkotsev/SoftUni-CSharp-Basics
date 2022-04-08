using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = "";

            for (int num = 1111; num <= 9999; num++)
            {
                string numString = num.ToString();
                int n1 = int.Parse(numString[0].ToString());
                int n2 = int.Parse(numString[1].ToString());
                int n3 = int.Parse(numString[2].ToString());
                int n4 = int.Parse(numString[3].ToString());

                if (n1 != 0 && n2 != 0 && n3 != 0 && n4 != 0)
                {
                    if (n % n1 == 0 && n % n2 == 0 && n % n3 == 0 && n % n4 == 0)
                    {
                        output += $"{numString} ";
                    }
                }

            }
            Console.WriteLine(output);
        }
    }
}
