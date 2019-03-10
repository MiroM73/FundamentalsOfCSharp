using System;

namespace Chapter08
{
    class Exercise04
    {
        static void Main(string[] args)
        {
            //4.Write a program that converts a decimal number to binary one.
            Console.WriteLine("EX4: Convert a positive decimal number to binary.");
            Console.Write("Enter positive decimal number: ");
            string consoleInputEx4 = Console.ReadLine();
            bool consoleInputIsDec = decimal.TryParse(consoleInputEx4, out decimal consoleInputDec);
            if (consoleInputIsDec)
            {
                decimal decTmp = consoleInputDec;
                string decToBinResult = decTmp == 0 ? "0" : "";

                while (decTmp > 0)
                {
                    decToBinResult = decToBinResult.Insert(0, (decTmp % 2).ToString());
                    decTmp = Math.Floor(decTmp / 2);
                }

                Console.WriteLine("{0} in dec = {1} in bin", consoleInputEx4, decToBinResult);
            }
            else
            {
                Console.WriteLine("{0} is not a positive decimal number!!!", consoleInputEx4);
            }
        }
    }
}
