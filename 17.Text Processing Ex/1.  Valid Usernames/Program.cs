namespace _1.__Valid_Usernames
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining username (input)
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            // Iterate trough all the usernames
            foreach (string currnames in usernames)
            {
                //sh
                if (currnames.Length>3&& currnames.Length<=16)
                {
                    // cheking if the username is valid
                    bool isUsernameValid = true;
                    foreach (char currChar in currnames)// => charArray =[s, h]

                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar=='-' 
                            || currChar=='_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(currnames);
                    }
                }
            }
        }
    }
}
