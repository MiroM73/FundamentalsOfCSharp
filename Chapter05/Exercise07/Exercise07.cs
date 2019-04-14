using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Write("Enter the numbers delimited by space:");            
            List<int> enteredNumbersList = new List<int>();            
            foreach (var item in Console.ReadLine().Split(new char[] { ' ' }))
            {
                enteredNumbersList.Add(int.Parse(item));
            }
            int[] enteredNumbers = enteredNumbersList.ToArray();
            Array.Sort(enteredNumbers);
            Console.WriteLine("The largest number is: " + enteredNumbers[enteredNumbers.Length - 1]);                       
        }
    }
}
