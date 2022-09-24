namespace _2._Sum_Digits
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            int sum = 0;
            while (nCopy>0)
            {
                int lastdigit = nCopy % 10;
                nCopy /= 10;
                sum += lastdigit;
                if (nCopy == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
