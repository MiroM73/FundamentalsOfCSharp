using System;

namespace Chapter06
{
    class Exercise05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX05: Write a program that reads from the console number N and print the sum\n" +
                "      of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … \n");
            
            Console.Write("Enter positive number N: ");
            int numberF = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int nextNumber = 1;
            int sumOfFibonacci = 1;
            if (numberF <= 1)
            {
                Console.WriteLine($"Entered number {numberF} <= 1!");
            }
            else
            {
                Console.Write($"{number1} {number2} ");
                for (int i = 3; i <= numberF; i++)
                {
                    sumOfFibonacci += nextNumber;
                    Console.Write($"{nextNumber} ");
                    number1 = number2;
                    number2 = nextNumber;
                    nextNumber = number1 + number2;
                }
                Console.WriteLine();
                Console.WriteLine("Sum = " + sumOfFibonacci);
            }
        }
    }
}
