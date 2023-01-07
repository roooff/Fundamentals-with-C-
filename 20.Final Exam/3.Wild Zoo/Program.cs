using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Wild_Zoo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool istrue = true;

            while (istrue)
            {
                string input = Console.ReadLine();
                if (input == "EndDay")
                {
                    istrue = false;
                    break;
                }
                string[] cmd = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmd[0] == "Add:")
                {
                    string animalName = cmd[1];
                    int food = int.Parse(cmd[2]);
                    string area = cmd[3];
                    var animal = new Dictionary<string, int>();
                    if (animal.ContainsKey(animalName))
                    {
                        int oldfood = animal[animalName];
                        animal[animalName] = oldfood + food;
                    }
                }
                else if (cmd[0] == "Feed:")
                {
                    string animalName = cmd[1];
                    string givenFodd = cmd[2];
                }
            }
        }
    }
}