using System;

namespace _0._1_Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 - 2 – baby
            //•	3 - 13 – child
            //•	14 - 19 – teenager
            //•	20 - 65 – adult
            //•	>= 66 – elder
            //•	All the values are inclusive.
            int age = int.Parse(Console.ReadLine());
            string type = string.Empty;
            if (age <=2)
            {
                type = "baby";
            }
            else if (age >=3 &&age <=13)
            {
                type = "child";
            }
            else if (age >=14 && age<=19)
            {
                type = "teenager";
            }
            else if(age >=20 && age <=65)
            {
                type = "adult";
            }
            else if (age >= 65)
            {
                type = "elder";
            }
            Console.WriteLine(type);
        }
    }
}
