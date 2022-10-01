namespace _10._LadyBugs
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Intilize empty field  
            int n = int.Parse(Console.ReadLine());//field size
            int[] field = new int[n];
            //2.Spawn ladybugs on the valid indexes
            //this collection remains uncharged
            int[] initialIndexes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (int index in initialIndexes)
            {
                if (index >=0 && index <field.Length)
                {
                    // Valid index >= initialise lady bug
                    field[index] = 1;
                }
            }
            //3. Proceed game moves(Start Game)
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(cmdArg[0]);
                string direction = cmdArg[1];
                int flyLength = int.Parse(cmdArg[2]);
                //3.1 Validate ladybug index is inside the field!
                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    //Invalid index >= nothing happends
                    continue;

                }
                //3.2 Validate ladybugIndex contains ladybug
                if (field[ladybugIndex] == 0)
                {
                    // There is no ladybug there => Nothing happens
                    continue;
                }
                //3.3 Try to procced move
                // Right -> ladybugIndex + flyllenght
                // left-> ladybugIndex - flyLength
                // First -> our ladybug starts flying => removes from the field
                field[ladybugIndex] = 0;
                if (direction=="left")
                {
                    flyLength *= -1;//1=>-1
                }

                //0 right 1 => 0+1    =1
                //1 left  1 => 1+(-1) =0
                
                int nextIndex = ladybugIndex + flyLength;
                while (nextIndex >=0 && nextIndex< field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength;
                }
                //there are two possibilities 
                // a : next index is calculated in the field
                //b: next index cannort be calculated in the field
                if (nextIndex <0 || nextIndex >= field.Length)
                {
                    // outside of the field
                    continue;
                }
                field[nextIndex] = 1;
            }
            Console.WriteLine(String.Join(" ", field));

        }
    }
}
