using System;

namespace _10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Every second lost game, Petar trashes his headset.
            //Every third lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int cntHeadset = 0;
            int cntMouse = 0;
            int cntKeyboard = 0;
            int cntDisplay = 0;
            double expenses = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i == 6 || i % 6 == 0)
                {
                    cntMouse += 1;
                    cntHeadset += 1;
                    cntKeyboard += 1;
                }
                else if (i == 2 || i % 2 == 0)
                {
                    cntHeadset += 1;
                }
               else if (i == 3 || i % 3 == 0)
                {
                    cntMouse += 1;
                }
                
                if (i == 12 || i % 12 == 0)
                {
                    cntDisplay += 1;
                }
            }
            expenses = cntMouse * mousePrice + cntKeyboard * keyboardPrice + cntHeadset * headsetPrice + cntDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
            
        }
    }

}
