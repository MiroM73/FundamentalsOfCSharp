using System;

namespace Chapter05
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            //11. * Write a program that converts a number in the range[0…999] to
            //words, corresponding to the English pronunciation. Examples:
            //            - 0-- > "Zero"
            //            - 12-- > "Twelve"
            //            - 98-- > "Ninety eight"
            //            - 273-- > "Two hundred seventy three"
            //            - 400-- > "Four hundred"
            //            - 501-- > "Five hundred and one"
            //            - 711-- > "Seven hundred and eleven"
            Console.WriteLine("EX11: A program that converts a number in the range [0 ... 999] to\n" +
                "words, corresponding to the English pronunciation. Examples:\n" +
                "            - 0 ---- > \"Zero\"\n" +
                "            - 12 --- > \"Twelve\"\n" +
                "            - 98 --- > \"Ninety eight\"\n" +
                "            - 273 -- > \"Two hundred seventy three\"\n" +
                "            - 400 -- > \"Four hundred\"\n" +
                "            - 501 -- > \"Five hundred and one\"\n" +
                "            - 711 -- > \"Seven hundred and eleven\"\n");            
            Console.Write("Enter the integer: ");
            string inputFromConsole = Console.ReadLine();
            bool isNumber = int.TryParse(inputFromConsole, out int number);
            if (!isNumber)
            {
                Console.WriteLine($"The entered input \"{inputFromConsole}\" is not an integer!!!");
                Environment.Exit(2);
            }
            int decNumber = 1;
            int unitNumber = 1;
            string hundredPrefix = "";

            string[] basicNumbers = { "", "One", "Two" , "Three" , "Four" , "Five" , "Six" , "Seven" , "Eight" , "Nine" , "" ,
                "Eleven" , "Twelve" , "Thirteen" , "Fourteen" , "Fifteen" , "Sixteen" , "Seventeen" , "Eighteen" , "Nineteen"};
            string[] multipliesOfTen = { "", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number <= 1 || number > 999)
            {
                Console.WriteLine($"The entered number {number} is out of the scope (1..999).");
                Environment.Exit(2);
            }

            if (number >= 100)
            {
                hundredPrefix = basicNumbers[number / 100] + " hundred ";
            }

            if (number <= 19 && number != 10)
            {
                Console.WriteLine($"The entered number {number} is in English: {basicNumbers[number]}");
            }
            else if (number > 19 && (number % 10) != 0 && number < 999)
            {
                decNumber = number / 10;
                if (decNumber > 10)
                {
                    decNumber = decNumber % 10;
                }
                unitNumber = number % 10;
                Console.WriteLine($"The entered number {number} is in English: " +
                    $"{hundredPrefix} and" +
                    (hundredPrefix.Length > 2 ? (multipliesOfTen[decNumber]).ToLower() : multipliesOfTen[decNumber]) +
                    " " + (basicNumbers[unitNumber]).ToLower());
            }
            else if (number >= 10 && (number % 10) == 0 && number < 100)
            {
                Console.WriteLine($"The entered number {number} in english is: " + multipliesOfTen[number / 10]);
            }
            else if (number >= 100 && (number % 10) == 0 && number < 901)
            {
                Console.WriteLine($"The entered number {number} in english is: {hundredPrefix}");
            }
        }
    }
}
