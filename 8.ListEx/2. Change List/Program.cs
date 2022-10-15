namespace _2._Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
                IsDeleteorInsert(cmdArgs, numbers);
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        private static void IsDeleteorInsert(string[] cmdArgs, List<int> numbers)
        {
            if (cmdArgs.Length - 1 == 2)
            {
                Insert(cmdArgs, numbers);
            }
            else if (cmdArgs.Length - 1 == 1)
            {
                Delete(cmdArgs, numbers);
            }
        }

        private static bool IsThatAll(List<int> numbers, string[] cmdArgs)
        {
            while (numbers.Contains(int.Parse(cmdArgs[1])))
            {
                Delete(cmdArgs, numbers);
            }
            return true;
        }

        private static void Delete(string[] cmdArgs, List<int> numbers)
        {
            int element = int.Parse(cmdArgs[1]);
            numbers.Remove(element);
            IsThatAll(numbers, cmdArgs);
        }

        private static void Insert(string[] cmdArgs, List<int> numbers)
        {
            int element = int.Parse(cmdArgs[1]);
            int position = int.Parse(cmdArgs[2]);
            numbers.Insert(position, element);
        }
    }
}