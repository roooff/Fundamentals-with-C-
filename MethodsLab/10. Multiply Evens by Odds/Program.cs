using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//123456
            int absValue = Math.Abs(int.Parse(input));
            int sumOfEvenDigits = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(absValue.ToString());
            int result = sumOfEvenDigits * sumOfOddDigits;
            Console.WriteLine(result);
        }

        static int GetSumOfOddDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNumber = (int.Parse(input[i].ToString()));
                if (currNumber %2 !=0)
                {
                    sum += currNumber;
                }

            }
            return sum;

        }

        static int GetSumOfEvenDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNumber = (int.Parse(input[i].ToString()));
                if (currNumber %2==0)
                {
                    sum += currNumber;
                }
            }
            return sum;
        }
    }
}
