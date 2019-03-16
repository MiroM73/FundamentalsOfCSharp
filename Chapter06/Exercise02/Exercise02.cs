using System;

namespace Chapter06
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX02: Write a program that prints on the console the numbers from 1 to N,\n" +
                "      which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.\n");
            Console.Write("Enter a number N: ");
            int numberNN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberNN; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
