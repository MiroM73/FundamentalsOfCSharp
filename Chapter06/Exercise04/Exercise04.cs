using System;

namespace Chapter06
{
    class Exercise04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX04: Write a program that prints all possible cards from a standard deck\n" +
                "      of cards, without jokers(there are 52 cards: 4 suits of 13 cards).\n");             
            Console.WriteLine("Printing all possible cards from a standard deck of cards:\n");
            string[] colors = { "Heart", "Club", "Diamond", "Spade" };
            foreach (var color in colors)
            {
                for (int i = 2; i <= 14; i++)
                {
                    switch (i)
                    {
                        case 11:
                            Console.Write("{0}_{1} ", color, "Jack");
                            break;
                        case 12:
                            Console.Write("{0}_{1} ", color, "Queen");
                            break;
                        case 13:
                            Console.Write("{0}_{1} ", color, "King");
                            break;
                        case 14:
                            Console.Write("{0}_{1} ", color, "Ace");
                            break;
                        default:
                            Console.Write("{0}_{1} ", color, i);
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
