using System;

namespace Chapter08
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            //2.Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.
            Console.WriteLine("EX2: Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.");
            string[] conversionTable = ("0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F").Split(new char[] { ',' }); //convert numbers 0 .. 15 to string
            string binNumber = "1111010110011110";
            string resultHex = "";
            double resultDec = 0;
            char[] binNumberArray = binNumber.ToCharArray();
            //convert binary number to decimal
            for (int i = 0; i < binNumberArray.Length; i++)
            {
                //using algorithm for converting any numeral system to dec system;
                //in this exercise, every single binary digit is multiplied by 2 raised to the 
                //power of the position it is in. In the end all of the numbers resulting from
                //the binary digits are added up to get the decimal value of the binary number. 
                //example: 11001(bin) = 1×2^4 + 1×2^3 + 0×2^2 + 0×2^1 + 1×2^0 = 16 + 8 + 1 = 25
                //From this follows that 11001(bin) = 25(dec)
                resultDec += int.Parse(binNumberArray[i].ToString()) * Math.Pow(2, binNumberArray.Length - i - 1);
            }           

            //convert decimal to hexa
            double resultDecTmp = resultDec;
            while (resultDecTmp > 0)
            {
                //use an appropriate string from the array "conversionTable" by index and add it to the top of the result string
                resultHex = resultHex.Insert(0, conversionTable[(int)(resultDecTmp % 16)]);
                resultDecTmp = Math.Floor(resultDecTmp / 16);
            }

            Console.WriteLine("Bin number {0} equal {1} in hex.", binNumber, resultHex);
            Console.WriteLine("Bin number {0} equal {1} in dec.", binNumber, resultDec);
        }
    }
}
