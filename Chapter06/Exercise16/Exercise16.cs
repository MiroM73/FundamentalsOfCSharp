using System;

namespace Chapter06
{
    class Exercise16
    {
        static void Main(string[] args)
        {
            Console.Write("EX16: Write a program that by a given integer N prints the numbers from 1 to N in random order.\n");
            Console.Write("Enter number N: ");
            int inputInt = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            string inputString = "";
            for (int i = 1; i <= inputInt ; i++)
            {
                inputString = inputString.Insert(inputString.Length, i.ToString());
            }
            Console.WriteLine("Radomized input {0} is {1}.", inputString, Randomize(inputString));

            Console.Write("Enter an integer / string and I will randomize it: ");
            inputString = Console.ReadLine();            
            Console.WriteLine("Radomized input {0} is {1}.", inputString, Randomize(inputString));
        }

        static string Randomize(string inputString)
        {
            Random rnd = new Random();
            string input = inputString;
            string rndResult = "";
            int intRnd = 0;
            int rndInputLength = input.Length;
            for (int i = 0; i < rndInputLength; i++)
            {
                intRnd = rnd.Next(0, input.Length - 1);
                rndResult += input.Substring(intRnd, 1);
                input = input.Remove(intRnd, 1);
            }
            return rndResult;
        }
    }
}
