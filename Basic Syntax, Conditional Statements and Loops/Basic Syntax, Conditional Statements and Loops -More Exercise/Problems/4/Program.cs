using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            for (int i = input.Length-1; i >=0; i--)
            {
                char curCh = input[i];
                

                Console.Write(curCh);
            }
        }
    }
}
