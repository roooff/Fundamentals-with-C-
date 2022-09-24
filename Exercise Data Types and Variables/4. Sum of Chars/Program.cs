namespace _4._Sum_of_Chars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            uint sum = 0;
            for (int i = 0; i <n; i++)
            {
                char cuurCh = char.Parse(Console.ReadLine());

                sum += (uint)cuurCh;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
