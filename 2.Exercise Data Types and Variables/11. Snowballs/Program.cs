namespace _11._Snowballs
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            // n = snowballs
            // max value is used for comparison and binding max value
            // these are just variauble holiding someproperties of maxed snobbal value
            BigInteger maxvalue = BigInteger.MinusOne;
            int maxSnow = int.MinValue;
            int maxTime = int.MinValue;
            int maxQuality = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > maxvalue)
                {
                    maxvalue = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }
                
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxvalue} ({maxQuality})");
        }
    }
}
