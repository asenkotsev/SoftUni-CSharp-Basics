using System;

namespace TimeAdd15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if(minutes >= 45)
            {
                hours++;
                minutes = (minutes += 15) % 60;
            } else
            {
                minutes = minutes += 15;
            }
            if(hours == 24)
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
