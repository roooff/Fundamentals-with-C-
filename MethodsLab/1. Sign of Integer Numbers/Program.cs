namespace _1.Sign_of_Integer_Numbers
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTypeOfNumber(number);
        }

        private static void PrintTypeOfNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}