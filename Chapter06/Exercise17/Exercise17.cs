using System;

namespace Chapter06
{
    class Exercise17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX17: Write a program that for given two numbers finds their greatest common\n" +
                "divisor (GCD) and their least common multiple (LCM). You may use\n" +
                "the formula LCM(a, b) = | a * b | / GCD(a, b).\n");
                        
            Console.Write("Enter integer A: ");
            int intA = int.Parse(Console.ReadLine());
            Console.Write("Enter integer B: ");
            int intB = int.Parse(Console.ReadLine());
            int lowerInt = intA > intB ? intB : intA;
            int biggerInt = intA > intB ? intA : intB;
            int gcd = 1;
            if (biggerInt % lowerInt == 0)
            {
                gcd = lowerInt;
            }
            else
            {
                for (int i = 1; i <= lowerInt / 2; i++)
                {
                    if (intA % i == 0 && intB % i == 0)
                    {
                        gcd = i;
                    }
                }
            }
            int lcm = (intA * intB) / gcd;
            Console.WriteLine("GCD of numbers GCD({0},{1}) = {2}.", intA, intB, gcd);
            Console.WriteLine("LCM of numbers LCM({0},{1}) = {2}.", intA, intB, lcm);
        }
    }
}
