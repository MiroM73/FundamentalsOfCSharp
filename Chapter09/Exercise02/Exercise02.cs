using System;

namespace Chapter09
{
    internal class Exercise02
    {
        static void Main(string[] args)
        {
            //2.Create a method GetMax() with two integer(int) parameters, that
            //returns maximal of the two numbers. Write a program that reads three
            //numbers from the console and prints the biggest of them. Use the
            //GetMax() method you just created. Write a test program that validates
            //that the methods works correctly.
            Console.WriteLine("EX2: Enter 3 numbers, I will return bigest one.");
            Console.Write("Enter numer 1: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter numer 2: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter numer 3: ");
            int numberThree = int.Parse(Console.ReadLine());
            int biggestOne = numberOne;
            biggestOne = GetMax(numberOne, numberTwo);
            biggestOne = GetMax(biggestOne, numberThree);

            if (biggestOne >= numberOne && biggestOne >= numberTwo && biggestOne >= numberThree)
            {
                Console.WriteLine("The biggest number is " + biggestOne);
            }
            else
            {
                Console.WriteLine("Something is wrong, returned number {0} is not biggest!!!", biggestOne);
            }
        }

        static int GetMax(int x, int y)
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

    }
}
