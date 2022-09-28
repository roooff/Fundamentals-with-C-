namespace _3._Rounding_Numbers
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{number[i]} => {(int)Math.Round(number[i],
                    MidpointRounding.AwayFromZero)}");
            }
            Console.ReadKey();
        }
    }
}
