using System;

namespace TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0.0;

            if (0 <= sales && sales <= 500)
            {
                if (city == "Sofia")
                {
                    commission = sales * 0.05;
                }
                else if (city == "Varna")
                {
                    commission = sales * 0.045;
                }
                else if (city == "Plovdiv")
                {
                    commission = sales * 0.055;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                if (city == "Sofia")
                {
                    commission = sales * 0.07;
                }
                else if (city == "Varna")
                {
                    commission = sales * 0.075;
                }
                else if (city == "Plovdiv")
                {
                    commission = sales * 0.08;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                if (city == "Sofia")
                {
                    commission = sales * 0.08;
                }
                else if (city == "Varna")
                {
                    commission = sales * 0.1;
                }
                else if (city == "Plovdiv")
                {
                    commission = sales * 0.12;
                }
            }
            else if (sales > 10000)
            {
                if (city == "Sofia")
                {
                    commission = sales * 0.12;
                }
                else if (city == "Varna")
                {
                    commission = sales * 0.13;
                }
                else if (city == "Plovdiv")
                {
                    commission = sales * 0.145;
                }
            }

            if (commission > 0)
            {
                Console.WriteLine(commission.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
