namespace _4._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string username = cmdArgs[1];
                if (cmdType == "register")
                {
                    string licenseNumber = cmdArgs[2];
                    if (!register.ContainsKey(username))
                    {
                        register[username] = licenseNumber;
                        Console.WriteLine($"{username} registered {licenseNumber} successfully");
                    }
                    else
                    {
                        string registeredNumber = register[username];
                        Console.WriteLine($"ERROR: already registered with plate number {registeredNumber}");
                    }
                }
                else if (cmdType == "unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var dictionary in register)
            {
                Console.WriteLine($"{dictionary.Key} => {dictionary.Value}");
            }
        }
    }
}