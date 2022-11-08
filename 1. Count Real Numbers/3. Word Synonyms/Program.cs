﻿namespace _3._Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            //[string], new List<string>{str1, str1 ....}
            Dictionary<string,List<string>> synonyms
                = new Dictionary<string,List<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = n; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }
                synonyms[word].Add(synonym);
            }
            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
            
            
        }
    }
}
