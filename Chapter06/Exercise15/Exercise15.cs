using System;

namespace Chapter06
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            Console.Write("EX15: Write a program that converts a given number from hexadecimal to decimal notation.\n");
            Console.Write("Enter hexadecimal number: ");
            string consoleInput = Console.ReadLine().ToUpper();            
            decimal resultHexToDec = 0;

            for (int i = 0, j = consoleInput.Length - 1; i < consoleInput.Length; i++, j--)
            {
                if (int.TryParse(consoleInput.Substring(i, 1), out int tmpNumber))
                {
                    resultHexToDec += tmpNumber * (decimal)Math.Pow(16, j);
                }
                else
                {
                    switch (consoleInput.Substring(i, 1))
                    {
                        case "A":
                            resultHexToDec += 10 * (decimal)Math.Pow(16, j);
                            break;
                        case "B":
                            resultHexToDec += 11 * (decimal)Math.Pow(16, j);
                            break;
                        case "C":
                            resultHexToDec += 12 * (decimal)Math.Pow(16, j);
                            break;
                        case "D":
                            resultHexToDec += 13 * (decimal)Math.Pow(16, j);
                            break;
                        case "E":
                            resultHexToDec += 14 * (decimal)Math.Pow(16, j);
                            break;
                        case "F":
                            resultHexToDec += 15 * (decimal)Math.Pow(16, j);
                            break;
                        default:
                            Console.WriteLine("Character {0} is not from HEXA number. Can not convert input {1}" +
                                "", consoleInput.Substring(i, 1), consoleInput);
                            goto Error;
                    }
                }
            }
            Console.WriteLine(resultHexToDec);
        Error:
            Console.WriteLine();
        }
    }
}
