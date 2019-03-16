using System;

namespace Chapter09
{
    class Exercise07
    {
        static void Main(string[] args)
        {
            //7. Write a method that prints the digits of a given decimal number in a reversed order.
            //Example: 256, must be printed as 652.
            Console.WriteLine("EX07: 7. Write a method that prints the digits of a given decimal number in a reversed order.\n" +
                "      Example: 256, must be printed as 652.\n");

            Console.Write("Enter number: ");
            string inputNumber = Console.ReadLine();
            Console.WriteLine($"{inputNumber} in a reversed order {Reverse(inputNumber)}");            
        }
        
        static string Reverse(string inputNumber)
        {
            char[] inputNumberChar = inputNumber.ToCharArray();
            string reverseOrder = "";
            for (int i = inputNumberChar.Length - 1; i >= 0; i--)
            {
                reverseOrder += inputNumberChar[i];
            }
            return reverseOrder;
        }
    }
}
