using System;

namespace Chapter05
{
    class Exercise08
    {
        static void Main(string[] args)
        {
            // 8.Write a program that, depending on the user’s choice, inputs int, double
            //or string variable. If the variable is int or double, the program
            //increases it by 1.If the variable is a string, the program appends "*" at
            //the end.Print the result at the console. Use switch statement.
            Console.WriteLine("EX08: A program that, depending on the user’s choice, inputs int, double\n" +
                "or string variable. If the variable is int or double, the program\n" +
                "increases it by 1. If the variable is a string, the program appends \" * \" at\n" +
                "the end. Print the result at the console. Use switch statement.");
            Console.WriteLine("Enter an input and Zadaj vstup a nasledne zadaj o aky typ hodnoty ide (int, double, string).\n");
            Console.Write("Enter an input: ");
            string enteredInput = Console.ReadLine();
            Console.Write("Enter the type of the entered input.\n" +
                "If \"int\" enter 1, if \"double\" enter 2 and if \"string\" enter 3: ");
            string typeOfEnteredInput = Console.ReadLine();
            switch (typeOfEnteredInput)
            {
                case ("1"):
                    Console.WriteLine($"Your entered input is: {enteredInput}. The output is: " + (int.Parse(enteredInput) + 1));
                    break;
                case ("2"):
                    Console.WriteLine($"Your entered input is: {enteredInput}. The output is: " + (double.Parse(enteredInput) + 1));
                    break;
                case ("3"):
                    Console.WriteLine($"Your entered input is: {enteredInput}. The output is: {enteredInput}*");
                    break;
                default:
                    Console.WriteLine("You entered a bad type for the input you entered.");
                    break;
            }
        }
    }
}
