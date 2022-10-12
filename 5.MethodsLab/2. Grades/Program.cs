namespace _2._Grades
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeDecider(grade);
            Console.ReadKey();
        }

        private static void GradeDecider(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6)
            {
            }
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}