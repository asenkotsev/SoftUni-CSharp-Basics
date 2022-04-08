using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double recordAttempt = distance * timePerMeter + (Math.Floor(distance / 15) * 12.5);
            if (recordAttempt < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordAttempt.ToString("0.00")} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(recordAttempt - record).ToString("0.00")} seconds slower.");
            }
        }
    }
}
