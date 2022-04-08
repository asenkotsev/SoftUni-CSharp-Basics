using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;
            int combinations = 0;
            bool check = false;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    combinations++;
                    if (i + j == magicNum)
                    {
                        firstNum = i;
                        secondNum = j;
                        check = true;
                        break;
                    }
                }
                if (check) { break; }
            }

            if (check)
            {
                Console.WriteLine($"Combination N:{combinations} ({firstNum} + {secondNum} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
