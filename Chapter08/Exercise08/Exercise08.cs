using System;

namespace Chapter08
{
    class Exercise08
    {
        static void Main(string[] args)
        {
            //8.Write a program that converts a hexadecimal number to binary one. 
            Console.WriteLine("EX8: Converts a hexadecimal number to binary.");
            Console.Write("Enter hexa number: ");
            string consoleInputHexNumber = Console.ReadLine().ToUpper();
            string binResult = "";
            bool inputIsHexNumber = true;
            string[] arrayHexChars = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F".Split(new char[] { ',' });
            string[] arrayHexToBin = ("0000,0001,0010,0011,0100,0101,0110,0111," +
                                      "1000,1001,1010,1011,1100,1101,1110,1111").Split(new char[] { ',' });
            for (int i = 0; i < consoleInputHexNumber.Length; i++)
            {
                int indexOfHexChar = Array.IndexOf(arrayHexChars, consoleInputHexNumber.Substring(i, 1));
                if (indexOfHexChar >= 0)
                {
                    binResult += arrayHexToBin[indexOfHexChar];
                }
                else
                {
                    inputIsHexNumber = false;
                    Console.WriteLine("{0} is not hex number!!! Value {1} at position {2} " +
                        "from left side is invalid", consoleInputHexNumber, consoleInputHexNumber.Substring(i, 1), i + 1);
                    break;
                }
            }
            if (inputIsHexNumber)
            {
                Console.WriteLine("{0} in hex = {1} in bin", consoleInputHexNumber, binResult);
            }
        }
    }
}
