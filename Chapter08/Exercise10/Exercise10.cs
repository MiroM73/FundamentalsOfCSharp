using System;

namespace Chapter08
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            //10.Write a program that converts a binary number to decimal using the Horner scheme.
            Console.WriteLine("EX10: Converts a binary number to decimal using the Horner scheme / algorithm.");
            Console.Write("Enter binary number: ");
            string inputBinConsole = Console.ReadLine();
            ulong binToDecResultEx10 = 1;

            for (int i = 0; i < inputBinConsole.Length - 1; i++)
            {
                //example how to use Horner scheme
                //1001 = ((1 × 2 + 0) × 2 + 0) × 2 + 1 = 2 × 2 × 2 + 1 = 9 
                int nextBinNumber = int.Parse(inputBinConsole.Substring(i + 1, 1));
                binToDecResultEx10 = binToDecResultEx10 * 2 + (ulong)nextBinNumber;
            }
            Console.WriteLine("{0} in bin = {1} in dec", inputBinConsole, binToDecResultEx10);
        }
    }
}
