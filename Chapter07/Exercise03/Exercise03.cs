using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            //3.Write a program, which compares two arrays of type char lexicographically (character by character) and checks, 
            //which one is first in the lexicographical order.
            Console.WriteLine("EX03: Program, which compares the two arrays of the type char lexicographically (character by character) and checks, " +
                "which one is first in the lexicographical order.");
            Console.Write("Enter the characters for the first array: ");
            char[] firstCharArray = Console.ReadLine().ToCharArray();
            Console.Write("Enter the characters for the second array: ");
            char[] secondCharArray = Console.ReadLine().ToCharArray();
            bool arraysAreSame = false;

            if (firstCharArray.Length > secondCharArray.Length)
            {
                Console.WriteLine("The second array is in the lexicographic comparison first, because it's less characters.");
                Console.WriteLine("1. array length = {0}, 2. array length = {1}", firstCharArray.Length, secondCharArray.Length);
                return;
            }
            else if (firstCharArray.Length < secondCharArray.Length)
            {
                Console.WriteLine("The first array is in the lexicographic comparison first, because it's less characters.");
                Console.WriteLine("1. array length = {0}, 2. array length = {1}", firstCharArray.Length, secondCharArray.Length);
                return;
            }
            else
            {
                for (int i = 0; i < firstCharArray.Length; i++)
                {
                    if (firstCharArray[i] > secondCharArray[i])
                    {
                        Console.WriteLine("The length of the arrays is the same, but the second array is in the lexicographic comparison first\n," +
                            "because at the index \"{0}\" the first array has char \"{1}\" and the second array has \"{2}\".", i, firstCharArray[i], secondCharArray[i]);
                        //Console.ReadLine();
                        return;
                    }
                    else if (firstCharArray[i] < secondCharArray[i])
                    {
                        Console.WriteLine("The length of the arrays is the same, but the first array is in the lexicographic comparison first\n," +
                            "because at the index \"{0}\" the first array has char \"{1}\" and the second array has \"{2}\".", i, firstCharArray[i], secondCharArray[i]);
                        //Console.ReadLine();
                        return;
                    }
                    else                
                    {
                        arraysAreSame = true;
                    }
                }
            }
            if (arraysAreSame)
            {
                Console.WriteLine("The arrays are the same.");
            }            
        }
    }
}
