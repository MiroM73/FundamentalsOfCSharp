using System;

namespace Chapter06
{
    class Exercise09
    {
        static void Main(string[] args)
        {
            //9.Write a program that for a given integers n and x, calculates the sum: 
            //S = 1 + (1! / x) + (2! / x^2) + ... + (n! / x^n)
            Console.WriteLine("EX09: A program that for a given integers n and x, calculates the sum:\n" +
                "S = 1 + (1! / x) + (2! / x^2) + ... + (n! / x^n)\n");
            Console.Write("Enter an integer n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer x: ");
            int x = int.Parse(Console.ReadLine());
            double S = 1;
            double factI = 1;
            Console.Write("S = 1");
            for (int i = 1; i <= n; i++)
            {
                factI *= i; 
                S += factI / Math.Pow(x, i);
                Console.Write(" + ({0}! / {1}^{0})", i, x);
            }
            Console.WriteLine();
            Console.WriteLine($"S = {S}");

        }
    }
}
