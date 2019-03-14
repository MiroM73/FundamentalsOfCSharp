using System;

namespace Chapter07
{
    class Exercise04
    {
        static void Main(string[] args)
        {
            //4. Write a program, which finds the maximal sequence of consecutive 
            //equal elements in an array. E.g.: { 1, 1, 2, 3, 2, 2, 2, 1} -> { 2, 2, 2}. 
            Console.WriteLine("EX04: Program, which finds the maximal sequence of consecutive\n" +
                "equal elements in an array. E.g.: { 1, 1, 2, 3, 2, 2, 2, 1} -> { 2, 2, 2}.");
            Console.Write("Enter numbers delimited by comma: ");
            string[] inputIntArray = Console.ReadLine().Split(',');            
            int endIndex = 0;
            int maxSequenceLength = 1;
            int maxSequenceLengthTMP = 1;
            for (int i = 1; i < inputIntArray.Length; i++)
            {                
                if (int.Parse(inputIntArray[i-1]) == int.Parse(inputIntArray[i]))
                {
                    maxSequenceLengthTMP += 1;
                }
                else
                {
                    if (maxSequenceLength < maxSequenceLengthTMP)
                    {
                        maxSequenceLength = maxSequenceLengthTMP;
                        endIndex = i - 1;
                        maxSequenceLengthTMP = 1;
                    }
                }
            }
            Console.WriteLine($"length = {maxSequenceLength}, start index = {endIndex - maxSequenceLength + 1}, " +
                $"end index = {endIndex}");
            Console.Write(inputIntArray[endIndex - maxSequenceLength + 1]);
            for (int i = 1; i < maxSequenceLength; i++)
            {
                Console.Write($", {inputIntArray[endIndex - maxSequenceLength + 1 + i]}");
            }
            Console.WriteLine();
        }
    }
}
