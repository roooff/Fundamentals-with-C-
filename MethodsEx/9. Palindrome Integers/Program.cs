namespace _9._Palindrome_Integers
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = String.Empty;
            int number;

            while (input != "END")
            {
                input = Console.ReadLine();
                if (input == "END") break;
                number = int.Parse(input);
                CheckPalindrome(number);
            }

            static void CheckPalindrome(int a)
            {
                int originalValue = a;
                string reversedToString = String.Empty;
                while (a > 0)
                {
                    reversedToString += a % 10;
                    a /= 10;
                }
                int reversed = int.Parse(reversedToString);
                if (reversed == originalValue)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}