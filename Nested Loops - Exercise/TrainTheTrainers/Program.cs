using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int assignmentCount = 0;
            double grades = 0;
            double finalGrades = 0;

            while (input != "Finish")
            {
                assignmentCount++;
                for (int i = 0; i < n; i++)
                {
                    grades += double.Parse(Console.ReadLine());
                }
                finalGrades += grades;
                Console.WriteLine($"{input} - {(grades / n).ToString("0.00")}.");
                grades = 0;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {(finalGrades / n / assignmentCount).ToString("0.00")}.");
        }
    }
}
