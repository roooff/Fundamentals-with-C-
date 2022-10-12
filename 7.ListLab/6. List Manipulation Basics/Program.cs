namespace _6._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> manipulated = new List<int>();

            manipulated = Command(integers);
            PrintList(manipulated);

            static void PrintList(List<int> numbers)
            {
                foreach (int item in numbers)
                {
                    Console.Write(item + " ");
                }
            }

            static List<int> Command(List<int> integers)
            {
                string input = Console.ReadLine();

                while (input != "end")
                {
                    string[] command = input.Split(" ");
                    switch (command[0])
                    {
                        case "Add":
                            integers = AddToList(command, integers);
                            break;

                        case "Remove":
                            integers = RemoveFromList(command, integers);
                            break;

                        case "RemoveAt":
                            integers = RemoveAtIndex(command, integers);
                            break;

                        case "Insert":
                            integers = InsertAtIndex(command, integers);
                            break;
                    }
                    input = Console.ReadLine();
                }
                return integers;
            }

            static List<int> AddToList(string[] command, List<int> integers)
            {
                integers.Add(int.Parse(command[1]));
                return integers;
            }

            static List<int> RemoveFromList(string[] command, List<int> integers)
            {
                integers.Remove(int.Parse(command[1]));
                return integers;
            }

            static List<int> RemoveAtIndex(string[] command, List<int> integers)
            {
                int index = int.Parse(command[1]);
                integers.RemoveAt(index);
                return integers;
            }

            static List<int> InsertAtIndex(string[] command, List<int> integers)
            {
                int number = int.Parse(command[1]);
                int index = int.Parse(command[2]);
                integers.Insert(index, number);
                return integers;
            }
        }
    }
}