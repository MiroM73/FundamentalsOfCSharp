using System;

namespace Chapter06
{
    class Exercise01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX01: Write a program that prints on the console the numbers from 1 to N.\n" +
                "      The number N should be read from the standard input.\n");
            Console.Write("Enter a positive integer N: ");
            int numberN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberN; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
