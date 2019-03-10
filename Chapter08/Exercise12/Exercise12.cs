using System;

namespace Chapter08
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            //12.Write a program that converts Arabic digits to Roman ones.            
            Console.WriteLine("EX12: Program that converts Arabic digits to Roman ones.");
            Console.Write("Enter number from 1 to 3999: ");
            string inputConsole = Console.ReadLine();

            string[][] romanNumbers = {
                new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
                new string[] { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
                new string[] { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
                new string[] { "M", "MM", "MMM" }
            };

            string resultInRoman = "";

            for (int i = 0, j = inputConsole.Length - 1; i < inputConsole.Length; i++, j--)
            {
                int inputNumber = int.Parse(inputConsole.Substring(j, 1));
                resultInRoman = resultInRoman.Insert(0, romanNumbers[i][inputNumber - 1]);
            }
            Console.WriteLine("{0} in Arabic = {1} in Roman", inputConsole, resultInRoman);
        }
    }
}
