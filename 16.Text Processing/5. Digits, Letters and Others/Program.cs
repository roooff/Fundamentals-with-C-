using System;
using System.Linq;
using System.Text;

namespace _5._Digits__Letters_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            char[] digits = input.Where(x => char.IsDigit(x)).ToArray();
            char[] letters = input.Where(x => char.IsLetter(x)).ToArray();
            char[] symbols = input.Where(x => !char.IsLetterOrDigit(x)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}
