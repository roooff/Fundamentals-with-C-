namespace SoftUni_Reception
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables of employees and students:
            int firstEm = int.Parse(Console.ReadLine());
            int secondEm = int.Parse(Console.ReadLine());
            int thirdEm = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            // Declaring power = firstEm + secondEm + thirdEm
            int power = firstEm + secondEm + thirdEm;
            // Declaring hour which is when we compare power to students
            int hour = 0;
            // Cheking
            
            while (students>0)
            {
             
                
                hour++;
                if (hour % 4==0)
                {
                    continue;
                }
                students -= power;
               
                
                
            }
            // End of this shit: 
            Console.WriteLine($"Time needed: {hour}h.");
            
            
        }
    }
}