namespace _9._Spice_Must_Flow
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            uint yield = uint.Parse(Console.ReadLine());
            uint yield2 = yield;
            uint yieldDrop = 10;
            uint workers = 26;
            uint sum = 0;
            uint yield3 = yield;
            int sum2 = 0;
            
            while (yield2 >=100)
            {
                sum2++;
                yield3 = yield2 - workers;
                yield2 -= yieldDrop;
                sum += yield3;

            }
            if (yield2<100)
            {
                sum -= workers;
            }
            Console.WriteLine(sum2);
            Console.WriteLine(sum);



        }
    }
}
