using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unacceptedGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            int gradesCount = 0;
            double totalGrades = 0;
            string problemName = Console.ReadLine();
            bool check = false;
            string lastProblem = "";

            while(problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                totalGrades += grade;
                gradesCount++;
                if(grade <= 4)
                {
                    counter++;
                }
                if(unacceptedGrades == counter)
                {
                    check = true;
                    break;
                }
                lastProblem = problemName;
                problemName = Console.ReadLine();
            }

            if(check)
            {
                Console.WriteLine($"You need a break, {counter} poor grades.");
            } else
            {
                Console.WriteLine($"Average score: {(totalGrades / gradesCount).ToString("0.00")}");
                Console.WriteLine($"Number of problems: {gradesCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
