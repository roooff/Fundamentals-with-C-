namespace _7._Water_Overflow
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int tank = 0;
            int n= int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int pouredWater = int.Parse(Console.ReadLine());
                sum += pouredWater;

            }
            if (sum >255)
            {
                Console.WriteLine("Insufficient capacity!");
                Console.WriteLine(tank);
            }
            else
            {
                Console.WriteLine(sum); 
            }
        }
    }
}
