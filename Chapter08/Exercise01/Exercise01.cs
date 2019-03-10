using System;

namespace Chapter08
{
    class Exercise01
    {
        static void Main(string[] args)
        {
            //1.Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.
            Console.WriteLine("EX1: Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.");
            int[] numbersToConvert = { 151, 35, 43, 251, 1023, 1024 };
            for (int i = 0; i < numbersToConvert.Length; i++)
            {
                int numberToConvert = numbersToConvert[i];
                string result = "";
                while (numberToConvert > 0)
                {
                    result = result.Insert(0, (numberToConvert % 2).ToString());
                    numberToConvert = numberToConvert / 2;
                }
                Console.WriteLine("{0} = {1}", numbersToConvert[i], result);
            }
            //EndOfScript();
        }
    }
}
