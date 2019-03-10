using System;

namespace Chapter08
{
    class Exercise07
    {
        static void Main(string[] args)
        {
            //7.Write a program that converts a hexadecimal number to decimal one. 
            Console.WriteLine("EX7: Converts a hexadecimal number to a decimal.");
            Console.Write("Enter hexadecimal number: ");
            //convert input to upper, "conversionTable" contains characters in upper format
            string inputConsoleHex = (Console.ReadLine()).ToUpper();
            ulong hexToDecResult = 0;
            bool isHexNumber = true;
            string invalidCharacter = "";
            int invalidCharacterIndex = 0;
            //conversion table / array
            //the decimal value of every possible hexa character is expressed by its position / index in the array 
            string[] conversionTableEx7 = ("0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F").Split(new char[] { ',' });

            //go through an every character of the entered hexa number
            for (int i = 0; i < inputConsoleHex.Length; i++)
            {
                //find index of character in "conversionTable"
                int indexOfString = Array.IndexOf(conversionTableEx7, inputConsoleHex.Substring(i, 1));
                //if the index for the character exists (index must be integer in range 0 .. 15)
                if (indexOfString >= 0 && indexOfString < 16)
                {
                    //calculate a value for character at position i
                    //(value of character) * 16^(position of char from right and from zero)
                    hexToDecResult += (ulong)(indexOfString * Math.Pow(16, inputConsoleHex.Length - i - 1));
                }
                //the index of the character doesn't exist
                else
                {
                    isHexNumber = false;
                    invalidCharacter = inputConsoleHex.Substring(i, 1);
                    invalidCharacterIndex = i + 1;
                    break;
                }
            }

            if (isHexNumber)
            {
                Console.WriteLine("{0} in hex = {1} in dec", inputConsoleHex, hexToDecResult);
            }
            else
            {
                Console.WriteLine("{0} is not a hexadecimal number!!! Invalid char {1} at position {2} " +
                    "from the left side.", inputConsoleHex, invalidCharacter, invalidCharacterIndex);
            }
        }
    }
}
