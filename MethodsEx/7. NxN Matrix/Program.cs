namespace _7._NxN_Matrix
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);

            static void PrintMatrix(int filler)
            {
                for (int i = 0; i < filler; i++)
                {
                    for (int j = 0; j < filler; j++)
                    {
                        Console.Write(filler + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}