using System;
using System.Numerics;

namespace Chapter06
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX11: Write a program that calculates with how many zeroes the factorial of\n" +
                "      a given number ends.\n" +
                "      Examples:\n" +
                "      N = 10 -> N! = 3628800-> 2\n" +
                "      N = 20 -> N! = 2432902008176640000-> 4\n");

            Console.Write("Enter integer N: ");
            int nNumber = int.Parse(Console.ReadLine());
            BigInteger nFactorial = Factorial(nNumber);
            BigInteger nFactorialTmp = nFactorial;
            int numberOfZeros = 0;
            while (nFactorialTmp % 10 == 0)
            {
                nFactorialTmp = nFactorialTmp / 10;
                numberOfZeros += 1;
            }
            switch (numberOfZeros)
            {
                case 0:
                    Console.WriteLine("The factorial of {0} ({1}) has not zeros.", nNumber, nFactorial);
                    break;
                case 1:
                    Console.WriteLine("The factorial of {0} ({1}) ends with 1 zero.", nNumber, nFactorial);
                    break;
                default:
                    Console.WriteLine("The factorial of {0} ({1}) ends with {2} zeros.", nNumber, nFactorial, numberOfZeros);
                    break;
            }
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
