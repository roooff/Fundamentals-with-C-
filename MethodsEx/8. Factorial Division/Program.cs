namespace _8._Factorial_Division
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double result = GetFactorial(first) / GetFactorial(second);
            Console.WriteLine($"{result:f2}");

            static double GetFactorial(int a)
            {
                double result = 1;
                for (double i = a; i > 0; i--)
                {
                    result *= i;
                }

                return result;
            }
        }
    }
}