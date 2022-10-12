using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = SubstractThird(
                SumFirstSecond(first, second),
                third
            );
            Console.WriteLine(result);

            static int SumFirstSecond(int first, int second)
            {
                return first + second;
            }

            static int SubstractThird(int sum, int third)
            {
                return sum - third;
            }
        }
    }
}