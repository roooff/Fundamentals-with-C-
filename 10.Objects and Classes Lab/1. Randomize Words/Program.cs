namespace _1._Randomize_Words
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                Random random = new Random();
                int randomindex = random.Next(0, input.Length);
                string currwowrd = input[i];
                string nextword = input[randomindex];
                input[i] = nextword;
                input[randomindex] = currwowrd;
                
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
