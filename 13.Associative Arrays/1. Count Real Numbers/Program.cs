namespace _1._Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberOcc = new SortedDictionary<double, int>();
            double[] inputnums = Console.ReadLine()
                .Split() .Select(double.Parse) 
                .ToArray();
            foreach (var currnumer in inputnums)
            {
                if (!numberOcc.ContainsKey(currnumer))
                {
                    numberOcc.Add(currnumer, 0);
                }
                numberOcc[currnumer] += 1;
            }
            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
