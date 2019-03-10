using System;

namespace Chapter07
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            //2.Write a program, which reads two arrays from the console and checks
            //whether they are equal(two arrays are equal when they are of equal
            //length and all of their elements, which have the same index, are equal). 
            Console.WriteLine("EX2: Enter two arrays and I will check if they are equal");
            Console.Write("First array, split elements by comma: ");
            string inputStringOne = Console.ReadLine();
            string[] arrayOne = inputStringOne.Split(new char[] { ',' });
            Console.Write("Second array, split elements by comma: ");
            string inputStringTwo = Console.ReadLine();
            string[] arrayTwo = inputStringTwo.Split(new char[] { ',' });
            bool arraysAreEqual = true;
            if (arrayOne.Length != arrayTwo.Length)
            {
                Console.WriteLine("The arrays have different number of elements.");
            }
            else
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] != arrayTwo[i])
                    {
                        arraysAreEqual = false;
                        break;
                    }
                }
                if (arraysAreEqual)
                {
                    Console.WriteLine("Arrays are equal.");
                }
                else
                {
                    Console.WriteLine("Arrays are different.");
                }
            }
        }
    }
}
