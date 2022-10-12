using System;
using System.Reflection;

namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double gamePrice = 0;
            double moneyCopy = money;
            string games = string.Empty;
            double sum=0;
            while (true)
            {
                games = Console.ReadLine();   
                switch (games)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        if (moneyCopy >= gamePrice)
                        {
                            moneyCopy -= (float)39.99;
                            Console.WriteLine("Bought OutFall 4");
                            sum += gamePrice;
                        }
                        else  
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        gamePrice =15.99;
                        if (moneyCopy >= gamePrice)
                        {
                            moneyCopy -= (float)15.99;
                            Console.WriteLine("Bought CS: OG");
                            sum += gamePrice;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");   
                        }
                        break;
                    case "Zplinter Zell":
                        gamePrice =19.99;
                        if (moneyCopy >= gamePrice)
                        {
                            moneyCopy -= (float)19.99;
                            Console.WriteLine("Bouhgt Zplinter Zell");
                            sum += gamePrice;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        gamePrice =59.99;
                        if (moneyCopy >= gamePrice)
                        {
                            moneyCopy -= (float)59.99;
                            Console.WriteLine("Bought Honored 2");
                            sum += gamePrice;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "RoverWatch":
                        gamePrice =29.99;
                        if (moneyCopy >= gamePrice)
                        {
                            moneyCopy -= (float)29.99;
                            Console.WriteLine("Bought RoverWatch");
                            sum += gamePrice;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice =39.99;
                        if (moneyCopy >= gamePrice)
                        {
                            moneyCopy -= (float)39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            sum += gamePrice;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                                              
                        break;
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${(money - sum):f2}");
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (games== "Game Time")
                {
                    break;
                }
                if (moneyCopy < 0.00)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                else
                {
                    continue;
                }
                
                

            }
           
        }
    }
}
