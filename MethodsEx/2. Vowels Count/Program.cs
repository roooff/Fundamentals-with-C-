namespace _2._Vowels_Count
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1 way -> void method (string text) -> cW
            //2 WAY -> int Meethod (string text ) -> Main Cw
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);
        }

        private static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}