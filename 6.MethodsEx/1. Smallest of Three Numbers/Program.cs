namespace _1._Smallest_of_Three_Numbers
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = CompareTwoNumbers(
                CompareTwoNumbers(first, second),
                third);

            Console.WriteLine(result);

            static int CompareTwoNumbers(int first, int second)
            {
                return first < second ? first : second;
            }
        }
    }
}