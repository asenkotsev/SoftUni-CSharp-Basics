using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleepovers = int.Parse(Console.ReadLine());
            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = sleepovers * 50;
                    apartmentPrice = sleepovers * 65;
                    if (sleepovers > 7 && sleepovers <= 14)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    else if (sleepovers > 14)
                    {
                        studioPrice -= studioPrice * 0.30;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = sleepovers * 75.2;
                    apartmentPrice = sleepovers * 68.7;
                    if (sleepovers > 14)
                    {
                        studioPrice -= studioPrice * 0.2;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = sleepovers * 76;
                    apartmentPrice = sleepovers * 77;
                    break;
            }

            if (sleepovers > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {apartmentPrice.ToString("0.00")} lv.");
            Console.WriteLine($"Studio: {studioPrice.ToString("0.00")} lv.");
        }
    }
}
