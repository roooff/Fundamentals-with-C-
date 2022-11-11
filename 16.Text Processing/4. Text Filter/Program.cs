namespace _4._Text_Filter
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedword = Console.ReadLine()
                .Split(", ");
            string text = Console.ReadLine();
            foreach (var item in bannedword )
            {
                text = text.Replace(item,
                    new string('*', item.Length));
            }
        }
    }
}
