using System;
using System.Numerics;

namespace Chapter06
{
    class Exercise06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX06: Write a program that calculates N!/ K! for given N and K(1 < K < N).\n");            
            Console.Write("Enter N: ");            
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            //added a reference to System.Numerics assembly in the project
            //then added "using System.Numerics" to use BigInteger class
            BigInteger result = 1;
            for (int i = (k + 1); i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result for {0}! / {1}! is {2:E8}", n, k, result);
        }
    }
}
