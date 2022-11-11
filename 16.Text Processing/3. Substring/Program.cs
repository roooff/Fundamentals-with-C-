namespace _3._Substring
{
    using System;
    internal class Program 
    {
        static void Main(string[] args)
        {
            string scpecialWord = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(scpecialWord))
            {
                int startindex = text.IndexOf(scpecialWord);
                text = text.Remove(startindex, scpecialWord.Length);
            }
            Console.WriteLine(text);
        }
    }
}