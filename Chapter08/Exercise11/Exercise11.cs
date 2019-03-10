using System;

namespace Chapter08
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            //11.Write a program that converts Roman digits to Arabic ones.
            Console.WriteLine("EX11: Program that converts Roman digits to Arabic.");
            Console.Write("Enter number in Roman number system: ");
            string consoleInputRomanNumber = Console.ReadLine().ToUpper();
            int romanToArabicResult = 0;
            bool isRomanNumber = true;
            int[] romanToArabicNumbers = new int[consoleInputRomanNumber.Length];
            int consoleInputLengthReverse = 0;

            while (consoleInputLengthReverse < consoleInputRomanNumber.Length && isRomanNumber)
            {
                switch (consoleInputRomanNumber.Substring(consoleInputLengthReverse, 1))
                {
                    case "I":
                        romanToArabicNumbers[consoleInputLengthReverse] = 1;
                        break;
                    case "V":
                        romanToArabicNumbers[consoleInputLengthReverse] = 5;
                        break;
                    case "X":
                        romanToArabicNumbers[consoleInputLengthReverse] = 10;
                        break;
                    case "L":
                        romanToArabicNumbers[consoleInputLengthReverse] = 50;
                        break;
                    case "C":
                        romanToArabicNumbers[consoleInputLengthReverse] = 100;
                        break;
                    case "D":
                        romanToArabicNumbers[consoleInputLengthReverse] = 500;
                        break;
                    case "M":
                        romanToArabicNumbers[consoleInputLengthReverse] = 1000;
                        break;
                    default:
                        isRomanNumber = false;
                        break;
                }
                consoleInputLengthReverse++;
            }

            if (isRomanNumber)
            {
                for (int i = 0; i < romanToArabicNumbers.Length - 1; i++)
                {
                    if (romanToArabicNumbers[i] >= romanToArabicNumbers[i + 1])
                    {
                        romanToArabicResult += romanToArabicNumbers[i];
                    }
                    else
                    {
                        romanToArabicResult -= romanToArabicNumbers[i];
                    }
                }
                romanToArabicResult += romanToArabicNumbers[romanToArabicNumbers.Length - 1];
                Console.WriteLine("{0} in Roman = {1} in dec (Arabic)", consoleInputRomanNumber, romanToArabicResult);
            }
            else
            {
                Console.WriteLine("{0} is NOT a Roman number!!!", consoleInputRomanNumber);
            }
        }
    }
}
