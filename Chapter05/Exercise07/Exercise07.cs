using System;

namespace Chapter05
{
    class Exercise07
    {
        static void Main(string[] args)
        {
            //7.Write a program that finds the greatest of given 5 numbers.
            //Modified to find the largest number from the entered.
            Console.WriteLine("EX07: The program that finds the greatest of given 5 numbers.\n" +
                "Modified to find the largest number from the entered.\n");
            Console.Write("Enter the numbers delimited by comma:");            
            string enteredString = Console.ReadLine();
            int largestNumber = 0;
            for (int i = 0; i < enteredString.Split(',').Length; i++)
            {
                if (largestNumber < int.Parse(enteredString.Split(',')[i]))
                {
                    largestNumber = int.Parse(enteredString.Split(',')[i]);
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}
