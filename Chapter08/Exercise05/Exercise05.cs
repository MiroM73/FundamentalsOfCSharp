using System;

namespace Chapter08
{
    class Exercise05
    {
        static void Main(string[] args)
        {
            //5.Write a program that converts a binary number to decimal one. 
            Console.WriteLine("EX5: Converts a binary number to a decimal.");
            Console.Write("Enter binary number: ");
            string consoleInputEx5 = Console.ReadLine();
            ulong binToDecResult = 0;
            bool isNumber = false;

            for (int i = 0; i < consoleInputEx5.Length; i++)
            {
                isNumber = int.TryParse(consoleInputEx5.Substring(i, 1), out int consoleInputParseNumber);
                if (isNumber && (consoleInputParseNumber == 0 || consoleInputParseNumber == 1))
                {
                    binToDecResult += (ulong)(consoleInputParseNumber * Math.Pow(2, consoleInputEx5.Length - i - 1));
                }
                else
                {
                    Console.WriteLine("{0} is not binary number!!!", consoleInputEx5);
                    break;
                }
            }
            Console.WriteLine("{0} in bin = {1} in dec", consoleInputEx5, binToDecResult);
        }
    }
}
