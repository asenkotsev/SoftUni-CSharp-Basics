using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = 0.0;
            string operand = Console.ReadLine();

            switch (operand)
            {
                case "+":
                    c = a + b;
                    if (c % 2 == 0)
                    {
                        Console.WriteLine($"{a} + {b} = {c} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} + {b} = {c} - odd");
                    }
                    break;
                case "-":
                    c = a - b;
                    if (c % 2 == 0)
                    {
                        Console.WriteLine($"{a} - {b} = {c} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} - {b} = {c} - odd");
                    }
                    break;
                case "*":
                    c = a * b;
                    if (c % 2 == 0)
                    {
                        Console.WriteLine($"{a} * {b} = {c} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} * {b} = {c} - odd");
                    }
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                    }
                    else
                    {
                        c = a / b;
                        Console.WriteLine($"{a} / {b} = {c.ToString("0.00")}");
                    }
                    break;
                case "%":
                    if(b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                    } else
                    {
                        c = a % b;
                        Console.WriteLine($"{a} % {b} = {c}");
                    }
                    break;
            }
        }
    }
}
