using System;
using System.Numerics;

namespace Chapter06
{
    class Exercise07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX07: Write a program that calculates N!*K!/ (N - K)! for given N and K\n" +
                "      (1 < K < N).\n");
            Console.WriteLine("Enter two integers N and K where (1 < K < N) and I will calculate N! * K! / (N - K)!.");
            Console.Write("Enter N: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k1 = int.Parse(Console.ReadLine());
            BigInteger result1 = 1;
            int nMinusK = n1 - k1;
            //calculate N! / (N - K)!
            for (int i = (nMinusK + 1); i <= n1; i++)
            {
                result1 *= i;
            }
            //multiply N! / (N - K)! by K!
            for (int i = 1; i <= k1; i++)
            {
                result1 *= i;
            }
            Console.WriteLine("The result for {0}! * {1}! / ({0} - {1})! is {2:E3}", n1, k1, result1);
        }
    }
}
