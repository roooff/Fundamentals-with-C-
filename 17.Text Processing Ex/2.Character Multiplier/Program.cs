namespace _2.Character_Multiplier
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Step 1. Converting string input into a string Array
            /// Step 2. Creating a method that takes parameters
            /// Stwp 3. Creating an integer containing the sum 
            /// Adding otheer problems essentials
            /// Ebal sym wa w guza sichkite
            /// ishto nqma da opisnwam she obiq nakov toq za kakyw se ima
            /// za golqm programist li?
            /// Pedal malyk
            /// Step 4 - Finding which string is bigger than the other
            // By using Math.Min

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            GetStringSum(names[0], names[1]);
        }

        private static void GetStringSum(string v1, string v2)
        {
            int sum = 0;
            int minLength = Math.Min(v1.Length, v2.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += v1[i] * v2[i];
                
            }
            string longestLenghtString = v1;
            if (longestLenghtString.Length<v2.Length)
            {
                longestLenghtString = v2;
            }
            for (int i = minLength; i <longestLenghtString.Length; i++)
            {
                sum += longestLenghtString[i];
            }
            Console.WriteLine(sum);
        }

    }
}
