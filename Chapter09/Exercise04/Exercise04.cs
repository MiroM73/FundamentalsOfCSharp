using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09
{
    class Exercise04
    {
        static void Main(string[] args)
        {
            //4. Write a method that finds how many times certain number can be
            //found in a given array.Write a program to test that the method works correctly.
            Console.WriteLine("EX04: Write a method that finds how many times certain number can be\n" +
                "      found in a given array.Write a program to test that the method works correctly.\n");
            Console.Write("Enter the array of the numbers delimited by the comma: ");
            string[] inputArray = Console.ReadLine().Split(',');
            Console.Write("Enter the number which count you are looking for: ");
            string lookingFor = Console.ReadLine();

            Console.WriteLine($"The number / string {lookingFor} is {CountElementInArray(inputArray, lookingFor)} " +
                $"time/s in the array.");
        }

        static int CountElementInArray(string[] inputArray, string lookingFor)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (lookingFor == inputArray[i])
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
