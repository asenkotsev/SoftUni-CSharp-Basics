using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            string output = "";

            for(int rows = 1; rows <= n; rows++)
            {
                for(int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    output += $"{current} ";
                    current++;
                }
                Console.WriteLine(output);
                output = "";
                if (isBigger)
                {
                    break;
                }
            }
        }
    }
}
