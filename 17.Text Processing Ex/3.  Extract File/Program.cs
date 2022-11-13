namespace _3.__Extract_File
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\",
                StringSplitOptions.RemoveEmptyEntries);
            string file = input[input.Length - 1];
            string[] SplitFileName = file
                .Split('.', StringSplitOptions.RemoveEmptyEntries);
            string filename = SplitFileName[0];
            string extensions = SplitFileName[1];
            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extensions}");
        }
    }
}
