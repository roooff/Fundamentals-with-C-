namespace _3._Merging_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> firstC = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondC = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int n = Math.Min(firstC.Count, secondC.Count);
            for (int i = 0; i < n; i++)
            {
                result.Add(firstC[i]);
                result.Add(secondC[i]);
            }
            if (firstC.Count > secondC.Count)
            {
                for (int i = n; i < firstC.Count; i++)
                {
                    result.Add(firstC[i]);
                }
            }
            else if (secondC.Count > firstC.Count)
            {
                for (int i = n; i < secondC.Count; i++)
                {
                    result.Add(secondC[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}