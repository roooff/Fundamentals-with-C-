using System;
using System.Collections.Generic;
using System.Linq;

namespace Recap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToList();
            int maxCap = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdArgs[1]));
                }

                else if (cmdArgs[0] != "Add")
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int num = int.Parse(cmdArgs[0]);
                        int allSum = num + wagons[i];
                        if (allSum>maxCap)
                        {
                            continue;
                        }
                        else if (allSum<=maxCap)
                        {
                            wagons.RemoveAt(i);
                            wagons.Insert(i,allSum);
                        }

                    }
                }
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}