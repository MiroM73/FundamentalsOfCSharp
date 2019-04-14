using System;

namespace Chapter05
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            //3.Write a program that finds the biggest of three integers, using nested
            //if statements.
            Console.WriteLine("EX03: The program that finds the biggest of three integers, using nested if statements.");
            Console.Write("First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Third Number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine($"The biggest one is: {firstNumber}");
                }
                else
                {
                    if (secondNumber > thirdNumber)
                    {
                        Console.WriteLine($"The biggest one is: {secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"The biggest one is: {thirdNumber}");
                    }
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine($"The biggest one is: {secondNumber}");
                }
                else
                {
                    Console.WriteLine($"The biggest one is: {thirdNumber}");
                }
            }
        }
    }
}
