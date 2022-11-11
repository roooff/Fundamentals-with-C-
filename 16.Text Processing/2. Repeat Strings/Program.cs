namespace _2._Repeat_Strings
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] words = Console.ReadLine().Split();
            string result = string.Empty;
            foreach (var currword in words)
            {
                for (int i = 0; i < currword.Length; i++)
                {
                    result += currword;
                }
            
            }
            Console.WriteLine(result);
        }
    }
}
