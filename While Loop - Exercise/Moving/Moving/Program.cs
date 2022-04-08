using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = width * length * height;
            bool check = false;

            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                area -= boxes;
                if (area < 0)
                {
                    check = true;
                    break;
                }
                input = Console.ReadLine();
            }
            if (check)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(area)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{area} Cubic meters left.");
            }
        }
    }
}
