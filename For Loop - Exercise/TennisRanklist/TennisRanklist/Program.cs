using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double points = int.Parse(Console.ReadLine());
            double wins = 0;
            double finals = 0;
            double semiFinals = 0;

            for (int i = 0; i < n; i++)
            {
                string status = Console.ReadLine();
                if (status == "W")
                {
                    wins++;
                }
                else if (status == "F")
                {
                    finals++;
                }
                else if (status == "SF")
                {
                    semiFinals++;
                }
            }

            double tournaments = wins + finals + semiFinals;
            double wonPoints = wins * 2000 + finals * 1200 + semiFinals * 720;
            points += wonPoints;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(wonPoints / tournaments)}");
            Console.WriteLine($"{(wins / tournaments * 100).ToString("0.00")}%");
        }
    }
}
