using System;

namespace Chapter08
{
    class Exercise09
    {
        static void Main(string[] args)
        {
            //9.Write a program that converts a binary number to hexadecimal one. 
            Console.WriteLine("EX9: Converts a binary number to hexadecimal.");
            Console.Write("Enter binary number: ");
            string consoleInputBinNumber = Console.ReadLine();
            string hexResult = "";
            bool inputIsBinNumber = true;
            string[] arrayHexCharsEx9 = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F".Split(new char[] { ',' });
            string[] arrayBinStringsEx9 = ("0000,0001,0010,0011,0100,0101,0110,0111," +
                                      "1000,1001,1010,1011,1100,1101,1110,1111").Split(new char[] { ',' });
            //check if the count of the bits in the bin number is divided by 4 (no remainder)
            //if not, add the zeros to the top of the input bin number so that the count of the bits will be divided by 4 (no remainder)
            if (consoleInputBinNumber.Length < 4)
            {
                consoleInputBinNumber = consoleInputBinNumber.Insert(0, new String('0', 4 - consoleInputBinNumber.Length));
            }
            if (consoleInputBinNumber.Length % 4 != 0 && consoleInputBinNumber.Length > 4)
            {
                consoleInputBinNumber = consoleInputBinNumber.Insert(0, new String('0', consoleInputBinNumber.Length % 4));
            }

            //go through the input and select 4-bits parts             
            for (int i = 0; i < consoleInputBinNumber.Length; i += 4)
            {
                //for every part (4-bits starting from left) find index in the array arrayBinStrings
                int indexOfBinString = Array.IndexOf(arrayBinStringsEx9, consoleInputBinNumber.Substring(i, 4));
                //if index exists
                if (indexOfBinString >= 0)
                {
                    //the finded index is used to select the value from the array arrayHexChars and attach it to the result string
                    hexResult += arrayHexCharsEx9[indexOfBinString];
                }
                //if index does not exist
                else
                {
                    inputIsBinNumber = false;
                    Console.WriteLine("{0} is not hex number!!! 4-bits {1} at position {2} " +
                        "from left side are invalid", consoleInputBinNumber, consoleInputBinNumber.Substring(i, 4), i + 1);
                    break;
                }
            }
            if (inputIsBinNumber)
            {
                Console.WriteLine("{0} in bin = {1} in hex", consoleInputBinNumber, hexResult);
            }
        }
    }
}
