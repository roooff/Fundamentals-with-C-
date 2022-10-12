namespace _5._Print_Part_of_the_ASCII_Table
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int startindex = int.Parse(Console.ReadLine());
            int endindex = int.Parse(Console.ReadLine());
            // char -> int /int -> char
            for (int i = startindex; i < endindex; i++)
            {
                //We have numeric values of the character in our memory
                //We need to cast in order to get visual representation of the number
                char currCh = (char)i;
                Console.Write(currCh + " ");
            }
        }

    }
}
