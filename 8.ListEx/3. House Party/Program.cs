namespace _3._House_Party
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    //Is going
                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    list.Add(name);
                }
                else if (cmdArgs.Length == 4)
                {
                    if (!list.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    list.Remove(name);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}