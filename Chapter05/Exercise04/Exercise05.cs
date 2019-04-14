using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise05
    {
        static void Main(string[] args)
        {
            //5.Write a program that asks for a digit (0 - 9), and depending on the input,
            //shows the digit as a word(in English).Use a switch statement.
            Console.WriteLine("EX05: The Program that asks for a digit (0 - 9), and depending on the input, shows the digit as a word (in English). Use a switch statement.");
            Console.Write("Enter the integer in the range (0 - 9): ");
            int enteredInt = int.Parse(Console.ReadLine());
            switch (enteredInt)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("You didn't enter a number in the range (0 - 9).");
                    break;
            }
        }
    }
}
