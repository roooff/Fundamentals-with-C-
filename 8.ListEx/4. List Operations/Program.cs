namespace _4._List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (cmdType == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, numberToInsert);
                }
                else if (cmdType == "Remove")
                {
                    int removeindex = int.Parse(cmdArgs[1]);

                    if (IsIndexInvalid(numbers, removeindex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(removeindex);
                }
                else if (cmdType == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    if (direction == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else
                    {
                        ShiftListRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool IsIndexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;

        ///<summary>
        ///return true when index is valid
        ///false when its not
        ///</summary>
        ///
        private static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];//Always take 1st num
                numbers.RemoveAt(0);//
                numbers.Add(firstNumber);
            }
        }

        private static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers.Count - 1;
                numbers.RemoveAt(numbers.Count - 1);//
                numbers.Insert(0, lastNumber);
            }
        }
    }
}