using System;

namespace _4._Array_Rotation
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            for (int r = 1; r <=rotationsCount; r++)
            {
                int firstElement = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
