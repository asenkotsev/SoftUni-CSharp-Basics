using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            double lunchTime = breakLength * 0.125;
            double breakTime = breakLength * 0.25;
            double freeTime = breakLength - lunchTime - breakTime;

            if (freeTime >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(freeTime - episodeLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(episodeLength - freeTime)} more minutes.");
            }
        }
    }
}
