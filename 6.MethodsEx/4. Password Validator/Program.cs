namespace _4._Password_Validator
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLenghtValid = IsLengthValid(password);
            bool isPassword = IsPasswordAlphaNumeric(password);
            bool atLestDigits = AtLeast2Digits(password);
            if (!isLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPassword)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!atLestDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPassword && atLestDigits && isLenghtValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool IsLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        private static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool AtLeast2Digits(string password)
        {
            int digitsCount = 0;
            foreach (Char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2;
        }
    }
}