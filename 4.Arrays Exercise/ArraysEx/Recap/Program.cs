using System;
using System.Linq;

namespace Recap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            //1. Print array direct -> Print type of the variable
            // Benefit -> know the index of each element , reverse reading
            Console.WriteLine(String.Join(" ", numbers));
            //name of the collecttion
            //
            //
            //
            //
            // 2. Printing array direct -> type of varibale

            for (int i = 0; i < numbers.Length; i++)
            {
                int currnum = numbers[i];
                Console.WriteLine($" Index {i} -> {currnum}");
            }
            //
            //
            //
            //
            //
            // 3.Printing array direct -> type of varibale a
            // Benefit -> less code , easy to use
            ///
            //
            //

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            //1. Reverse reading using for :
            ///
            ///
            //

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currnum = numbers[i];
                Console.WriteLine($" Index {i} -> {currnum}");
            }
            //2. Reverse reading using for
            //
            //
            ///
            //

            for (int i = 0; i < numbers.Length; i++)
            {
                int currnum = numbers[numbers.Length - i - 1];
                Console.WriteLine($" Index {numbers[numbers.Length - i - 1]} -> {currnum}");
            }
            // Reading the numbers from the console with / /
            // Dynamic length --> Choosed by user's input
            // Cannot be changed after input
            //
            //
            //
            //
            int[] numebers2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            // Coppy the numbers in another array
            //1. Own copy algorithm
            //
            //
            //
            //
            //
            int[] arrCopy = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                arrCopy[i] = currNum;
            }
            Console.WriteLine(String.Join(" ", arrCopy));
            //2.  Alternative
            //
            //
            //
            //
            //
            //
            Array.Copy(numbers, arrCopy, numbers.Length);
            Console.WriteLine(String.Join(" ", arrCopy));
        }
    }
}