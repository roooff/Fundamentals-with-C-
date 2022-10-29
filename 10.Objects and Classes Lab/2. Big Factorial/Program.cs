namespace _2._Big_Factorial
{
    using System.Numerics;
    using System;
    internal class Program
    {
        private static void Main(string[] args)
        {
            BigInteger factoriel = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                factoriel *=i;
            }
            System.Console.WriteLine(factoriel);
        }
    }
}