using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTickets = 0;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidTickets = 0;
            double filmTickets = 0;
            bool isEnd = false;

            while (true)
            {
                string filmName = Console.ReadLine();
                if (filmName == "Finish")
                {
                    Console.WriteLine($"Total tickets: {totalTickets}");
                    Console.WriteLine($"{(studentTickets / totalTickets * 100).ToString("0.00")}% student tickets.");
                    Console.WriteLine($"{(standardTickets / totalTickets * 100).ToString("0.00")}% standard tickets.");
                    Console.WriteLine($"{(kidTickets / totalTickets * 100).ToString("0.00")}% kids tickets.");
                    break;
                }
                double tickets = double.Parse(Console.ReadLine());
                for (int i = 0; i < tickets; i++)
                {
                    string ticketType = Console.ReadLine();
                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            filmTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            filmTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            filmTickets++;
                            break;
                        case "End":
                            Console.WriteLine($"{filmName} - {(filmTickets / tickets * 100).ToString("0.00")}% full.");
                            totalTickets += filmTickets;
                            filmTickets = 0;
                            isEnd = true;
                            break;
                    }

                    if (isEnd)
                    {
                        isEnd = false;
                        break;
                    }
                    else if (tickets == filmTickets)
                    {
                        Console.WriteLine($"{filmName} - {(filmTickets / tickets * 100).ToString("0.00")}% full.");
                        totalTickets += filmTickets;
                        filmTickets = 0;
                        break;
                    }
                }
            }
        }
    }
}
