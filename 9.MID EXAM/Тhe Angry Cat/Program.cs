using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Тhe_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine() .Split(", " ,StringSplitOptions.RemoveEmptyEntries) .Select(int.Parse) .ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int startingINdex = items[entryPoint];
            if (type == "cheap")
            {
                startingINdex = items[entryPoint] - entryPoint;
                
            }

        }

    }
}
