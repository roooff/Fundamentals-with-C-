namespace _1._Sort_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int big = 0;
            int medium = 0;
            int small = 0;
            if (num1 >= num2&&num1 >= num3)
            {
                big = num1;
            }
            else if (num2 >= num1 && num2 >=num3)
            {
                big=num2;
            }
            else if (num3 >= num1 && num3>=num2)
            {
                big = num3;
            }
            if (num1 >= num2 && num1 <= num3)
            {
                medium = num1;
            }
             if (num2 >= num1 && num2 <= num3)
            {
                medium = num2;
            }
             if (num3 <= big && num3 <= num2)
            {
               medium = num3;
            }
            if (num1 <= num2 && num1 <= num3)
            {
                small = num1;
            }
            if (num2 <= num1 && num2 <= num3)
            {
                small = num2;
            }
             if (num3 <= num1 && num3 <= num2)
            {
                small = num3;
            }
            Console.WriteLine(big);
            Console.WriteLine(medium);
            Console.WriteLine(small);
        }
    }
}
