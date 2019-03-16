using System;

namespace Chapter09
{
    class Exercise06
    {
        static void Main(string[] args)
        {
            //6. Write a method that returns the position of the first occurrence of an
            //element from an array, such that it is greater than its two neighbors
            //simultaneously. Otherwise the result must be - 1.
            Console.WriteLine("EX06: Write a method that returns the position of the first occurrence of an\n" +
                "      element from an array, such that it is greater than its two neighbors simultaneously.\n" +
                "      Otherwise the result must be - 1.\n");

            Console.Write("Enter the array of the numbers delimited by the comma: ");
            string[] inputArray = Console.ReadLine().Split(',');

            Console.Write("Enter the element from array: ");
            string inputString = Console.ReadLine();
            
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                if (inputString == inputArray[i])
                {
                    bool isGreater = IsGreaterThenNeighbors(inputArray, i);
                    if (isGreater)
                    {
                        Console.WriteLine($"Number {inputArray[i]} at index {i}: {inputArray[i - 1]} < {inputArray[i]} > {inputArray[i + 1]} : {isGreater}");
                        return;
                    }
                }
                
            }
            Console.WriteLine("-1");
        }

        static bool IsGreaterThenNeighbors(string[] inputArray, int indexInArray)
        {
            if (int.Parse(inputArray[indexInArray]) > int.Parse(inputArray[indexInArray - 1]) && int.Parse(inputArray[indexInArray]) > int.Parse(inputArray[indexInArray + 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
