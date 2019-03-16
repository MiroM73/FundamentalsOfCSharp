using System;

namespace Chapter06
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX14: Write a program that converts a given number from decimal to hexadecimal notation.\n");            
            Console.Write("Enter decimal number: ");
            uint consoleUint = uint.Parse(Console.ReadLine());
            string resultHexaNumberString = "";
            string resultHexa = "";
            while (consoleUint > 0)
            {
                switch (consoleUint % 16)
                {
                    case 10:
                        resultHexaNumberString += "A";
                        break;
                    case 11:
                        resultHexaNumberString += "B";
                        break;
                    case 12:
                        resultHexaNumberString += "C";
                        break;
                    case 13:
                        resultHexaNumberString += "D";
                        break;
                    case 14:
                        resultHexaNumberString += "E";
                        break;
                    case 15:
                        resultHexaNumberString += "F";
                        break;
                    default:
                        resultHexaNumberString += consoleUint % 16;
                        break;
                }
                consoleUint = consoleUint / 16;
            }
            char[] resultCharArray = resultHexaNumberString.ToCharArray();
            for (int i = resultCharArray.Length - 1; i >= 0; i--)
            {
                resultHexa += resultCharArray[i];
            }
            Console.WriteLine(resultHexa);
        }
    }
}
