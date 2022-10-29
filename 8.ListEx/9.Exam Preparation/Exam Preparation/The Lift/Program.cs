namespace The_Lift
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());//15
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] <4 && people>0)
                {
                    while (lift[i] <4)
                    {
                        lift[i]++;
                         people--;
                    }
                }
            }
            if (people ==0 && lift.Any(x=> x<4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" " ,lift));

            }
            else if (people ==0 && lift.All(x=> x==4))
            {
                Console.WriteLine(string.Join(" ",lift));
            }
            else if(people!=0 && lift.All(x=> x==4))
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ",lift));
            }

            //Result 4 4 4 3



        }
    }
}
