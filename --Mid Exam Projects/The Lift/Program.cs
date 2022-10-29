namespace The_Lift
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // reading people in line from the first line from the console:
            int queue = int.Parse(Console.ReadLine());

            // Reading the wagons, storing them in a list<int>:
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            // Walking through every wagon till its end:
            for (int i = 0; i < wagons.Count; i++)
            {
                // Setting max value on wagon = 4:
                while (wagons[i] < 4)
                {
                    // Cheking if queue is empty:
                    if (queue > 0)
                    {
                        queue--;
                        wagons[i]++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            // Making end serachings:
            if (queue == 0 && wagons.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', wagons));
            }
            else if (queue != 0 && wagons.All(x => x == 4))
            {
                Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
                Console.WriteLine(string.Join(' ', wagons));
            }
            else if (queue == 0 && wagons.All(x => x == 4))
            {
                Console.WriteLine(string.Join(' ', wagons));
                Environment.Exit(queue);
            }
        }
    }
}