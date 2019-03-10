using System;

namespace Chapter07
{
    class Exercise01
    {
        static void Main(string[] args)
        {
            //1.Write a program, which creates an array of 20 elements of type
            //integer and initializes each of the elements with a value equals to the
            //index of the element multiplied by 5.Print the elements to the console.
            Console.WriteLine("EX1: Create an array of 20 elements with values index * 5.");
            int[] arrayExerciseOne = new int[20];
            for (int i = 0; i < arrayExerciseOne.Length; i++)
            {
                arrayExerciseOne[i] = i * 5;
            }
            foreach (var item in arrayExerciseOne)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
