﻿using System;
using System.Text.RegularExpressions;

namespace _2.Boss_Rush
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var regex = new Regex(@"\|(?<Name>[A-Z]{4,})\|\:\#(?<Title>[A-Za-z]+\s[A-Za-z]+)\#");
                var mach = regex.Match(input);

                if (mach.Success)
                {
                    var name = mach.Groups["Name"].Value;
                    var title = mach.Groups["Title"].Value;
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}