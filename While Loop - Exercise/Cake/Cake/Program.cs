using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            string input = Console.ReadLine();
            bool check = false;

            while(input != "STOP")
            {
                int pieces = int.Parse(input);
                area -= pieces;
                if (area < 0)
                {
                    check = true;
                    break;
                }
                input = Console.ReadLine();
            }

            if(check)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(area)} pieces more.");
            } else
            {
                Console.WriteLine($"{area} pieces are left.");
            }
        }
    }
}
