using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string grader = Console.ReadLine();
                double pointsFromGrader = double.Parse(Console.ReadLine());
                points += (pointsFromGrader * grader.Length) / 2;
                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points.ToString("0.0")}!");
                    break;
                }
            }
            if (points <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5 - points).ToString("0.0")} more!");
            }
        }
    }
}
