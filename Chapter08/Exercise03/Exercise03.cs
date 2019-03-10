using System;

namespace Chapter08
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            // 3.Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.
            Console.WriteLine("EX3: Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.");
            string[] inputHexaNumbers = { "FA", "2A3E", "FFFF", "5A0E9" };
            string[] conversionTableHexToDec = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F".Split(new char[] { ',' }); //convert numbers 0 .. 15 to string            
            string[] conversionTableHexToBin = "0000,0001,0010,0011,0100,0101,0110,0111,1000,1001,1010,1011,1100,1101,1110,1111".Split(new char[] { ',' });

            foreach (var inputHexNumber in inputHexaNumbers)
            {
                //convert hexa to dec
                double resultDecEx3 = 0;
                for (int i = 0; i < inputHexNumber.Length; i++)
                {
                    //get the index of the every part of the hex number from the "conversionTableEx3" and use it as the integer for conversion
                    //multiply the previous integer (index of hex number value from table) by 16 powered by its position 
                    //2A3E = 2 * 16^3 + A(10) * 16^2 + 3 * 16^1 + E(14) * 16^0 = 8192 + 2560 + 48 + 14 = 10814
                    // 2 -> index of 2 in table is 2
                    // A -> index of A in table is 10 ...
                    // 2 * 16^3 -> 16^3 -> value 2 has position 3 in the hex number 2A3E, 
                    //position is counted from right to left and start with zero
                    // A(10) * 16^2 -> value A is second so 16^2 ...
                    resultDecEx3 +=
                        Array.IndexOf(conversionTableHexToDec, inputHexNumber.Substring(i, 1)) *
                        Math.Pow(16, inputHexNumber.Length - i - 1);
                }
                Console.WriteLine("Hex number {0} equal {1} in dec.", inputHexNumber, resultDecEx3);

                //convert hexa to bin
                //every one character of hexa number is 4 bite number in binary system
                //so it is possible to use two arrays where the index of hexa value in HexToDec array 
                //will be the index of value in HexToBin table
                // hexa 0 = 0000 bin -> index of hexa 0 is 0 and index of bin 0000 is 0
                // hexa A = 1010 bin -> index of hexa A is 9 and index of bin 1010 is 9
                // hexa F = 1111 bin -> index of hexa F is 15 and index of bin 1111 is 15                
                string resultBinEx3 = "";
                string hexStrTmp = "";
                int hexStrTmpIndex = 0;
                for (int i = 0; i < inputHexNumber.Length; i++)
                {
                    hexStrTmp = inputHexNumber.Substring(i, 1);
                    hexStrTmpIndex = Array.IndexOf(conversionTableHexToDec, hexStrTmp);
                    resultBinEx3 += conversionTableHexToBin[hexStrTmpIndex];
                }
                Console.WriteLine("Hex number {0} equal {1} in bin.", inputHexNumber, resultBinEx3);
            }
        }
    }
}
