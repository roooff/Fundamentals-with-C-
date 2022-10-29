﻿namespace _4._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                double grade = double.Parse(cmdArgs[2]);
                Student currstudent = new Student(firstName, lastName, grade);
                students.Add(currstudent);
            }
            List<Student> orderedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string firsrtName, string lastName, double grade)
        {
            this.FirstName = firsrtName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public double Grade { get; private set; }
    }
}