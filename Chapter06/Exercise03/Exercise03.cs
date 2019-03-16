using System;
using System.Collections.Generic;

namespace Chapter06
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX03: Write a program that reads from the console a series of integers and\n" +
                "      prints the smallest and largest of them.\n");
            Console.Write("Enter the numbers delimited by space: ");
            List<int> inputNumbersTransformedList = new List<int>();
            foreach (var item in Console.ReadLine().Split(new char[] { ' ' }))
            {
                inputNumbersTransformedList.Add(int.Parse(item));
            }
            int[] inputNumbersInt = inputNumbersTransformedList.ToArray();
            Array.Sort(inputNumbersInt);
            Console.WriteLine($"The smallest one is {inputNumbersInt[0]} " +
                $"and the biggest one is {inputNumbersInt[inputNumbersInt.Length - 1]}");
        }
    }
}
