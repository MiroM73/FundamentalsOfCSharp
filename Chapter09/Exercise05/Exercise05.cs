using System;

namespace Chapter09
{
    class Exercise05
    {
        static void Main(string[] args)
        {
            //5. Write a method that checks whether an element, from a certain position
            //in an array is greater than its two neighbors. Test whether the
            //method works correctly.
            Console.WriteLine("EX05: Write a method that checks whether an element, from a certain position\n" +
                "      in an array is greater than its two neighbors. Test whether the method works correctly.\n");

            Console.Write("Enter the array of the numbers delimited by the comma: ");
            string[] inputArray = Console.ReadLine().Split(',');

            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                Console.WriteLine($" {inputArray[i - 1]} < {inputArray[i]} > {inputArray[i + 1]} : {IsGreaterThenNeighbors(inputArray, i)}");
            }
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
