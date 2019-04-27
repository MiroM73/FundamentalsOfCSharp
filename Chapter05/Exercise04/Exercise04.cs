using System;

namespace Chapter05
{
    class Exercise04
    {
        static void Main(string[] args)
        {
            //4.Sort 3 real numbers in descending order. Use nested if statements.
            Console.WriteLine("EX04: Sort 3 real numbers in descending order. Use nested if statements.");
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            double tmpNumber = 0;            
            if (firstNumber < secondNumber)
            {
                tmpNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = tmpNumber;                
            }
            if (secondNumber < thirdNumber)
            {
                tmpNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = tmpNumber;
                if (firstNumber < secondNumber)
                {
                    tmpNumber = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = tmpNumber;
                }
            }
            Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
        }
    }
}
