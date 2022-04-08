using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examTimeinMinutes = examHour * 60 + examMinutes;
            int arriveTimeinMinutes = arriveHour * 60 + arriveMinutes;

            double diff = examTimeinMinutes - arriveTimeinMinutes;
            double minutes = Math.Abs(diff % 60);
            double hours = Math.Truncate(Math.Abs(diff) / 60);

            if (diff > 0 && diff >= 31)
            {
                Console.WriteLine("Early");
                if (diff < 60)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    if (minutes <= 9)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
            }
            else if (diff <= 30 && diff >= 0)
            {
                Console.WriteLine("On time");
                if (diff != 0)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                diff = Math.Abs(diff);
                if (diff < 60)
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else
                {
                    if (minutes <= 9)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
            }
        }
    }
}
