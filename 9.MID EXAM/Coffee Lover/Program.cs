using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffee_Lover
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int n = int.Parse(Console.ReadLine());
            string[] cmdArgs;

            for (int i = 0; i < n; i++)
            {
                cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmdArgs[0] == "Include")
                {
                    coffees.Add(cmdArgs[1]);
                }
                if (cmdArgs[0] == "Remove")
                {
                    int numOfCoffees = int.Parse(cmdArgs[2]);
                    if (numOfCoffees <= coffees.Count - 1)
                    {
                        if (cmdArgs[1] == "first")
                        {
                            for (int j = 0; numOfCoffees != 0; j++)
                            {
                                coffees.RemoveAt(j);
                                numOfCoffees--;
                                j--;
                            }
                        }
                        else if (cmdArgs[1] == "last")
                        {
                            for (int j = coffees.Count - 1; numOfCoffees != 0; j--)
                            {
                                coffees.RemoveAt(j);
                                numOfCoffees--;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                if (cmdArgs[0] == "Prefer")
                {
                    int a = int.Parse(cmdArgs[1]);
                    int b = int.Parse(cmdArgs[2]);
                    if (coffees.Count - 1 >= a && coffees.Count - 1 >= b)
                    {
                        string tmp = coffees[b];
                        coffees[b] = coffees[a];
                        coffees[a] = tmp;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (cmdArgs[0] == "Reverse")
                {
                    coffees.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(String.Join(" ", coffees));
            

        }

    }
}