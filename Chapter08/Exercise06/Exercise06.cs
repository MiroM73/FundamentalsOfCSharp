using System;

namespace Chapter08
{
    class Exercise06
    {
        static void Main(string[] args)
        {
            //6.Write a program that converts a decimal number to hexadecimal one.
            Console.WriteLine("EX6: Converts a decimal number to hexadecimal.");
            Console.Write("Enter decimal number: ");
            string consoleInputEx6 = Console.ReadLine();
            bool consoleInputEx6IsNumber = decimal.TryParse(consoleInputEx6, out decimal consoleInputParseToDecimal);

            if (consoleInputEx6IsNumber)
            {
                string decToHexResult = "";
                string[] conversionTableEx6 = ("0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F").Split(new char[] { ',' }); //convert numbers 0 .. 15 to string
                decimal decToHexTmp = consoleInputParseToDecimal;

                while (decToHexTmp > 0)
                {
                    //use an appropriate string from the array "conversionTable" by index and add it to the top of the result string
                    decToHexResult = decToHexResult.Insert(0, conversionTableEx6[(int)(decToHexTmp % 16)]);
                    decToHexTmp = Math.Floor(decToHexTmp / 16);
                }
                Console.WriteLine("{0} in dec = {1} in hex", consoleInputEx6, decToHexResult);
            }
            else
            {
                Console.WriteLine("{0} is not a hex number!!!", consoleInputEx6);
            }
        }
    }
}
