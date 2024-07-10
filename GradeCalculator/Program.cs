using System;
// this program takes a numerical grade as input and determines the letter grade

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numerical grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            string letterGrade;

            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine("The letter grade is: " + letterGrade);
        }
    }
}
