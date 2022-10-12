namespace _5._Top_Integers
{
    using System;
    using System.Linq;

    namespace _5._Top_Integers
    {
        internal class Program
        {
            private static void Main(string[] args)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int i = 0; i < numbers.Length; i++)
                {
                    int currentNum = numbers[i];
                    // Pass trouhgh all num to its right
                    bool isTopIntegerer = true;
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        int nextNum = numbers[j];
                        if (nextNum >= currentNum)
                        {
                            isTopIntegerer = false; break;
                        }
                    }
                    if (isTopIntegerer)
                    {
                        Console.Write(currentNum + " ");
                    }
                }
            }
        }
    }