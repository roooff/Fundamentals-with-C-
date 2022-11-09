﻿namespace _4._Word_Filter
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split()
                .Where(n => n.Length %2==0)
                .ToArray();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
