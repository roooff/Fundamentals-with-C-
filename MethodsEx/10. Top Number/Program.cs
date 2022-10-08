namespace _10._Top_Number
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            PrintTopNumbers(end);

            static int CheckIfNumIsTop(int a)
            {
                int originalValue = a;
                int digitSum = 0;
                bool isOdd = false;
                while (a > 0)
                {
                    digitSum += a % 10;
                    if ((a % 10) % 2 != 0) isOdd = true;
                    a /= 10;
                }

                if ((digitSum % 8 == 0) && isOdd)
                    return originalValue;

                return 1;
            }

            static void PrintTopNumbers(int end)
            {
                for (int i = 1; i <= end; i++)
                {
                    if (CheckIfNumIsTop(i) != 1)
                        Console.WriteLine(i);
                }
            }
        }
    }
}