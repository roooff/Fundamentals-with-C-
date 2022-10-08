namespace _6._Middle_Characters
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMiddleElement(input));

            static string GetMiddleElement(string str)
            {
                string middle = String.Empty;
                if (str.Length % 2 == 0)
                {
                    middle = str[str.Length / 2 - 1].ToString() + str[str.Length / 2].ToString();
                }
                else
                {
                    middle = str[str.Length / 2].ToString();
                }

                return middle;
            }
        }
    }
}