namespace _3._Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            foreach (Match item in matchCollection)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}