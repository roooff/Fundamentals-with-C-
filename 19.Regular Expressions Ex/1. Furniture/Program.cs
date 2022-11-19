namespace _1._Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            double totalmoneyspent = 0;
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quiantity>\d+)(\.\d+)?$";
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(inputLine, pattern);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quiantity = int.Parse(match.Groups["quiantity"].Value);
                    furniture.Add(furnitureName);
                    totalmoneyspent += pricePerUnit * quiantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (string furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {totalmoneyspent:f2}");
        }
    }
}