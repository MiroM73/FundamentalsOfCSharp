using System;
using System.Numerics;

namespace Chapter06
{
    class Exercise08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX08: In combinatorics, the Catalan numbers are calculated by the following\n" +
                "      formula:\n" +
                "      (2n)! / ((n + 1)! * n!), for n >= 0.\n" +
                "      Write a program that calculates the n-th Catalan number by given n.\n");
            
            Console.Write("Enter number N: ");
            int nCatalan = int.Parse(Console.ReadLine());
            BigInteger nCatalanResult = Factorial(2 * nCatalan) / (Factorial(nCatalan + 1) * Factorial(nCatalan));
            Console.WriteLine("Result for n-th Catalan number (2 * {0}!) / (({0} + 1)! * {0}!) = {1:E6}", nCatalan, nCatalanResult);
        }

        static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            while (number > 0 && number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}
