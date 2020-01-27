using System;

namespace MIS_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your lastname?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your studentID?");
             string StudentID = (Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homework?");
            double homework = Convert.ToDouble(Console.ReadLine());
            double homeworkGrade = 0.25 * homework;

            Console.WriteLine("What is your overall percentage grade for participation?");
            double participation = Convert.ToDouble(Console.ReadLine());
            double participationGrade = .10 * participation;

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizzes = Convert.ToDouble(Console.ReadLine());
            double quizzesGrade = .10 * quizzes;

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());
            double midtermGrade = .25 * midterm;

            Console.WriteLine("What is your overall percentage grade for the final?");
            double final = Convert.ToDouble(Console.ReadLine());
            double finalGrade = .30 * final;

            
            double result = (homeworkGrade + participationGrade + quizzesGrade + midtermGrade + finalGrade)/100; 
            Console.WriteLine($" {name} {lastname}, ({StudentID}) Your final grade is: {result.ToString("P2")} ");
            

        }
    }
}
