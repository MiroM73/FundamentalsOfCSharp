using System;

namespace Chapter08
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            //14.Try adding up 50,000,000 times the number 0.000001.Use a loop
            //and addition(not direct multiplication). Try it with float and double and
            //after that with decimal.Do you notice the huge difference in the
            //results and speed of calculation? Explain what happens.
            Console.WriteLine("EX:14 compare result for float, double and decimal");
            Console.WriteLine("Add real number 0.000001 50 000 000 times using float, double and decimal type:");
            float numberFloat = 0.0f;
            for (int i = 0; i < 50000000; i++)
            {
                numberFloat += 0.000001f;
            }
            Console.WriteLine($"Float: {numberFloat} not accurate result, but the high speed.");

            double numberDouble = 0.0d;
            for (int i = 0; i < 50000000; i++)
            {
                numberDouble += 0.000001d;
            }
            Console.WriteLine($"Double: {numberDouble} not accurate result, but the high speed.");

            decimal numberDecimal = 0.0M;
            for (int i = 0; i < 50000000; i++)
            {
                numberDecimal += 0.000001M;
            }
            Console.WriteLine($"Decimal: {numberDecimal} the resault is accurate, but the speed is slowest.");
        }
    }
}
