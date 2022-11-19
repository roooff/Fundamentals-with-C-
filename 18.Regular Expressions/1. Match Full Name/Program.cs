namespace _1._Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string pattern = @"w+";
            var input = "Raffy";
            var regex = new Regex(pattern);
            bool isMatch = regex.IsMatch(input);
            Console.WriteLine(isMatch);
        }
    }
}