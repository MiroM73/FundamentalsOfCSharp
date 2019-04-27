using System;

namespace Chapter05
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            //10.Write a program that applies bonus points to given scores in the range
            //[1…9] by the following rules: 
            //- If the score is between 1 and 3, the program multiplies it by 10.
            //- If the score is between 4 and 6, the program multiplies it by 100.
            //- If the score is between 7 and 9, the program multiplies it by 1000.
            //- If the score is 0 or more than 9, the program prints an error
            //message.
            Console.WriteLine("EX10: A program that applies bonus points to given scores in the range\n" +
                "[1…9] by the following rules:\n" +
                "- If the score is between 1 and 3, the program multiplies it by 10.\n" +
                "- If the score is between 4 and 6, the program multiplies it by 100.\n" +
                "- If the score is between 7 and 9, the program multiplies it by 1000.\n" +
                "- If the score is 0 or more than 9, the program prints an error message.\n");
            Console.Write("Enter score in the range 1..9: ");
            int score = int.Parse(Console.ReadLine());
            if (1 <= score && score <= 3)
            {
                Console.WriteLine($"Score {score} is between 1 and 3. {score} * 10 = " + (score * 10));
            }
            else if (4 <= score && score <= 6)
            {
                Console.WriteLine($"Score {score} is between 4 and 6. {score} * 100 = " + (score * 100));
            }
            else if (7 <= score && score <= 9)
            {
                Console.WriteLine($"Score {score} is between 7 and 9. {score} * 1000 = " + (score * 1000));
            }
            else if (0 == score || score == 9)
            {
                Console.WriteLine($"Score {score} is ZERO or NINE: ERROR");
            }
            else
            {
                Console.WriteLine($"Entered value: {score}, is out of range.");
            }
        }
    }
}
