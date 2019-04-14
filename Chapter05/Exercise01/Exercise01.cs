using System;

namespace Chapter05
{
    class Exercise01
    {
        static void Main(string[] args)
        {
            //1.Write an if-statement that takes two integer variables and exchanges
            //their values if the first one is greater than the second one.
            Console.WriteLine("EX01: An if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.");
            Console.WriteLine("Enter two integers.");
            Console.Write("First One: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Second One: ");
            int secondInt = int.Parse(Console.ReadLine());
            if (firstInt > secondInt)
            {
                int cisloTmp = firstInt;
                firstInt = secondInt;
                secondInt = cisloTmp;
            }
            Console.WriteLine($"Integers ordered: {firstInt}, {secondInt}.");            
        }
    }
}
