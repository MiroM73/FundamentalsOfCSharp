using System;

namespace Chapter05
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            //2.Write a program that shows the sign ( + or -) of the product of three real
            //numbers, without calculating it. Use a sequence of if operators.
            Console.WriteLine("EX02: Program that shows the sign (+ or -) of the product of three real numbers, without calculating it.");            
            Console.Write("First number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
            {
                Console.WriteLine("The product of the entered numbers is 0.");

            }
            else
            {
                int sumOfNegativResults = 0;
                if (firstNumber < 0)
                {
                    sumOfNegativResults += 1;
                }
                if (secondNumber < 0)
                {
                    sumOfNegativResults += 1;
                }
                if (thirdNumber < 0)
                {
                    sumOfNegativResults += 1;
                }
                if (sumOfNegativResults % 2 == 0)
                {
                    Console.WriteLine("The product of entered numbers is positive \"+\"");
                }
                else
                {
                    Console.WriteLine("The product of entered numbers is negativ \"-\"");
                }
            }
        }
    }
}
