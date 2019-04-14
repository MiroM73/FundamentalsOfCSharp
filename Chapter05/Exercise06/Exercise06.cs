using System;

namespace Chapter05
{
    class Exercise06
    {
        static void Main(string[] args)
        {
            //6.Write a program that gets the coefficients a, b and c of a quadratic
            //equation: ax2 + bx + c, calculates and prints its real roots(if they exist). 
            //Quadratic equations may have 0, 1 or 2 real roots.
            Console.WriteLine("EX06: The program that gets the coefficients a, b and c of a quadratic\n" +
                "equation: ax2 + bx + c, calculates and prints its real roots (if they exist).\n" +
                "Quadratic equations may have 0, 1 or 2 real roots.\n");
            Console.WriteLine("Enter numbers for the equation a*x*x + b*x + c.");
            Console.Write("Enter value for a: ");
            double valueA = double.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            double valueB = double.Parse(Console.ReadLine());
            Console.Write("Enter value for c: ");
            double valueC = double.Parse(Console.ReadLine());
            double root1;
            double root2;
            double discriminant = (valueB * valueB) - (4 * valueA * valueC); //calculate a discriminant
            if (discriminant == 0) //there is one result, if the discriminant equals zero
            {
                root1 = (-valueB) / (2 * valueA);
                Console.WriteLine($"The equation of {valueA}*x2 + {valueB}*x + {valueC} has one root: x = {root1}");
            }
            else if (discriminant > 0) //there are two results, if the discriminant is the positive number
            {
                root1 = ((-valueB) + Math.Sqrt((valueB * valueB) - (4 * valueA * valueC))) / (2 * valueA);
                root2 = ((-valueB) - Math.Sqrt((valueB * valueB) - (4 * valueA * valueC))) / (2 * valueA);
                Console.WriteLine($"The equation of {valueA}*x2 + {valueB}*x + {valueC} has two roots: x1 = {root1}, x2 = {root2}");
            }
            else //there is not the result in the real number, if the discriminant is the negative number
            {
                Console.WriteLine($"The equation of {valueA}*x2 + {valueB}*x + {valueC} does not have the real root.");
            }
        }
    }
}
