﻿using System;

namespace _1.Train
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagons];
            int totalPassengers = 0;

            for (int i = 0; i < wagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                totalPassengers += passengers[i];
            }

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(totalPassengers);
        }
    }
}