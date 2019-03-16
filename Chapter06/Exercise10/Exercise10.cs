using System;

namespace Chapter06
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX10: Write a program that reads from the console a positive integer number\n" +
                "      N from (1 .. 19) and prints a matrix of numbers as on the figures below:\n" +
                "      N = 3\n" +
                "       1 2 3\n" +
                "       2 3 4\n" +
                "       3 4 5\n\n" +
                "      N = 4\n" +
                "       1 2 3 4\n" +
                "       2 3 4 5\n" +
                "       3 4 5 6\n" +
                "       4 5 6 7\n");

            Console.Write("Enter number N from (1 .. 19). I will return a matrix: ");
            int intMatrix = int.Parse(Console.ReadLine());
            if (intMatrix > 0 && intMatrix < 20)
            {
                for (int i = 1; i <= intMatrix; i++)
                {
                    for (int j = i; j < (intMatrix + i); j++)
                    {
                        if (j > 9)
                        {
                            Console.Write($"{j} ");
                        }
                        else
                        {
                            Console.Write($"{j}  ");
                        }

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"The number you entered is out of def N from (1 .. 19)." +
                    $" Entered integet {intMatrix} " + (intMatrix > 19 ? "is greater then 19." : "is lower then 1."));
            }
        }
    }
}
