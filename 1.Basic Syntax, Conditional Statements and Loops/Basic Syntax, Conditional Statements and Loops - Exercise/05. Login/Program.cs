using System;
namespace _05._Login
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length-1; i >= 0; i--)
            {
                char currCh = username[i];
                password+=currCh;
            }
            int totalTries = 0;
            string enteredPassword;
            int success = 0;
            while ((enteredPassword = Console.ReadLine()) != password)
            {

                
                if (totalTries >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    success += 1;
                    break;
                }
                else  
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
                totalTries++;
            }
            if (success ==0)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
        }
    }
}
