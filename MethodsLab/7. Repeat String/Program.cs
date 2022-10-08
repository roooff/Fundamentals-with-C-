using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(input, n);
            Console.WriteLine(result);
        }

        private static string RepeatString(string input, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += input;
                
            }
            return result;
        }
    }
}