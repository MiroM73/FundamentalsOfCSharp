using System;

namespace Chapter07
{
    class Exercise05
    {
        static void Main(string[] args)
        {
            //5. Write a program, which finds the maximal sequence of consecutively 
            //placed increasing integers.Example: { 3, 2, 3, 4, 2, 2, 4} -> { 2, 3, 4}. 
            Console.WriteLine("EX05: Program, which finds the maximal sequence of consecutively\n" +
                "      placed increasing integers. Example: { 3, 2, 3, 4, 2, 2, 4} -> { 2, 3, 4}.\n");

            Console.Write("Enter numbers delimited by comma: ");
            string[] inputIntArray = Console.ReadLine().Split(',');
            int endIndex = 0;
            int maxSequenceLength = 1;
            int maxSequenceLengthTMP = 1;
            for (int i = 1; i < inputIntArray.Length; i++)
            {
                if (int.Parse(inputIntArray[i - 1]) + 1 == int.Parse(inputIntArray[i]))
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
