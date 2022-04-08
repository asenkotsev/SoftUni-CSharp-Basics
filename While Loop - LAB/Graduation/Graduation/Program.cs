using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            int currentClass = 1;
            double totalGrades = 0;
            int gradeCount = 0;
            int index = 0;

            while (true)
            {
                if (grade >= 4)
                {
                    currentClass++;
                    totalGrades += grade;
                    index = 0;
                    gradeCount++;
                }
                else
                {
                    totalGrades += grade;
                    index++;
                    gradeCount++;
                }
                if (index == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {currentClass} grade");
                    break;
                }
                if (currentClass > 12)
                {
                    Console.Write($"{name} graduated. Average grade: {(totalGrades / gradeCount).ToString("0.00")}");
                    break;
                }
                grade = double.Parse(Console.ReadLine());
            }
        }
    }
}
