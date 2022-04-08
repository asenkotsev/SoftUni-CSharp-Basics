using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string output = "";

            for(int i = floors; i > 0; i--)
            {
                output = "";
                for (int j = 0; j <= rooms; j++)
                {
                    if (i == floors && j < rooms)
                    {
                        output += $"L{i}{j} ";
                    }
                    else if (i % 2 == 0 && j < rooms)
                    {
                        output += $"O{i}{j} ";
                    } else if (j < rooms)
                    {
                        output += $"A{i}{j} ";
                    }
                }
                Console.WriteLine(output);
            }
        }
    }
}
