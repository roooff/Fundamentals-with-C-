namespace _4.__Caesar_Cipher
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedString = string.Empty;
            foreach (char currChar in input)
            {
                int currPosition = currChar;
                currPosition += 3;
                encryptedString += (char)currPosition;
            }
            Console.WriteLine(encryptedString);
        }
    }
}