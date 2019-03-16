using System;

namespace Chapter06
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX13: Write a program that converts a given number from binary to decimal notation.\n");            
            Console.Write("Enter binary number: ");
            string numberBinary1 = Console.ReadLine();
            uint numberDecimal1 = 0;
            int intExponent = numberBinary1.Length - 1;
            for (int i = 0; i < numberBinary1.Length; i++)
            {
                if (numberBinary1.Substring(i, 1) == "1")
                {
                    numberDecimal1 = numberDecimal1 + (uint)Math.Pow(2, intExponent);
                }
                intExponent--;
            }
            Console.WriteLine(numberDecimal1);
        }
    }
}
