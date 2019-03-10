using System;

namespace Chapter09
{
    internal class Exercise03
    {
        static void Main(string[] args)
        {
            //3.Write a method that returns the English name of the last digit of a
            //given number. Example: for 512 prints "two"; for 1024 -> "four".
            Console.WriteLine("EX3: Method that returns the English name of the last digit.");
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            Console.WriteLine($"The last entered number in the number {number} is {GetNumberName(int.Parse(number.Substring(number.Length - 1, 1)))}.");
        }

        static string GetNumberName(int number)
        {
            string[] numberNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            return numberNames[number];
        }        
    }
}
