using System;
using System.Linq;

namespace _1._Decrypting_Commands
{
    internal class Program
    {
        private static void Main()
        {
            // decrypting command

            string strmod = Console.ReadLine();

            while (true)
            {
                string[] cmd = Console.ReadLine().Split(new[] { ' ' }).ToArray();

                if (cmd[0] == "Finish")
                    break;

                if (cmd[0] == "Replace")
                {
                    string currentChar = cmd[1];
                    string newChar = cmd[2];
                    strmod = strmod.Replace(currentChar, newChar);
                    Console.WriteLine(strmod);
                }

                if (cmd[0] == "Cut")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int length = Math.Abs(startIndex - endIndex) + 1;

                    if (startIndex < 0 || endIndex > strmod.Length)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    strmod = strmod.Remove(startIndex, length);
                    Console.WriteLine(strmod);
                }

                if (cmd[0] == "Make")
                {
                    if (cmd[1] == "Upper")
                    {
                        strmod = strmod.ToUpper();
                    }

                    if (cmd[1] == "Lower")
                    {
                        strmod = strmod.ToLower();
                    }

                    Console.WriteLine(strmod);
                }

                if (cmd[0] == "Check")
                {
                    Console.WriteLine((strmod.Contains(cmd[1]) ? "Message contains " + cmd[1] : "Message doesn't contain " + cmd[1]));
                }

                if (cmd[0] == "Sum")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);

                    if (startIndex < 0 || endIndex > strmod.Length)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    int asciiSum = 0;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        asciiSum += strmod[i];
                    }

                    Console.WriteLine(asciiSum);
                }
            }
        }
    }
}