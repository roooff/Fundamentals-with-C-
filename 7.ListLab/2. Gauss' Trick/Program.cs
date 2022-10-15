﻿namespace _2._Gauss__Trick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currSum = numbers[i] + numbers[numbers.Count - 1 - i];

                result.Add(currSum);
            }
            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}