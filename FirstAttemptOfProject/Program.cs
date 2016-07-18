using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAttemptOfProject
{
    class Deck
    {
        

    }



    class Program
    {
        static void Main(string[] args)
        {
            List<string> Suits = new List<string>();
            Suits.Add("Spades");
            Suits.Add("Hearts");
            Suits.Add("Clubs");
            Suits.Add("Diamonds");
            int length = Suits.Count -1;

            for (int counter = 0; counter <= length; counter++)
            {
                if (counter % 2 != 0) 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(Suits[counter]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine(Suits[counter]);
                }
            }
            





            /*
            Console.WriteLine(Suits[0]);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(Suits[1]);
            Console.ResetColor();
            Console.WriteLine(Suits[2]);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(Suits[3]);
            Console.ResetColor();
            */
        }
    }
}
