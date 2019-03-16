using System;

namespace Chapter06
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX12: Write a program that converts a given number from decimal to binary\n" +
                "      notation(numeral system).\n");            
            Console.Write("Enter positive integer: ");
            uint numberConsole = uint.Parse(Console.ReadLine());
            uint numberTmp = numberConsole;
            string numberDecimal = "";
            string numberBinary = "";
            while (numberTmp > 0)
            {
                numberDecimal += numberTmp % 2;
                numberTmp = numberTmp / 2;
            }

            char[] arrayDecimal = numberDecimal.ToCharArray();

            for (int i = arrayDecimal.Length - 1; i >= 0; i--)
            {
                numberBinary += arrayDecimal[i];
            }
            Console.WriteLine(numberBinary);

            //print binary result in format xxxx xxxx xxxx xxxx 
            int leadingZeros = 0;
            if (arrayDecimal.Length % 4 != 0)
            {
                for (int i = 0; i < ((((arrayDecimal.Length / 4) + 1) * 4) - arrayDecimal.Length); i++)
                {
                    Console.Write("0");
                    leadingZeros++;
                }
            }

            for (int i = arrayDecimal.Length - 1, j = 1; i >= 0; i--, j++)
            {
                Console.Write(arrayDecimal[i]);
                if ((j + leadingZeros) % 4 == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
