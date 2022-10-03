namespace _2._Common_Elements
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                {
                    string[] first = Console.ReadLine()
                          .Split(" ");
                    string[] second = Console.ReadLine()
                          .Split(" ");
                    string common = string.Empty;

                    for (int i = 0; i < second.Length; i++)
                    {
                        int index = 0;
                        while (index < first.Length)
                        {
                            if (second[i] == first[index])
                            {
                                common += (second[i] + " ");
                            }

                            index++;
                        }
                    }
                    string[] result = common.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    Console.WriteLine(string.Join(" ", result));
                }
            }
        }
    }
}