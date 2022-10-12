namespace _3._Elevator
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int numOfCourses = n / p;
            if (n%p !=0)
            {
                numOfCourses++;
            }
            Console.WriteLine(numOfCourses);
        }
    }
}
