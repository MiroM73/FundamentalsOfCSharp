using System;

namespace Chapter08
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            //13.Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number
            //N from an S-based numeral system to a D based numeral system. 
            Console.WriteLine("EX13: Program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N \n" +
                "      from an S-based numeral system to a D based numeral system.");
            Console.Write("Enter source numeral system 2 .. 16: ");
            int sourceNumSystem = int.Parse(Console.ReadLine());
            if (sourceNumSystem < 2 || sourceNumSystem > 16)
            {
                Console.WriteLine("Source numeral system \"{0}\" is out of the range 2 .. 16", sourceNumSystem);
                goto End;
            }
            Console.Write("Enter destination numeral system 2 .. 16: ");
            int destNumSystem = int.Parse(Console.ReadLine());
            if (destNumSystem < 2 || destNumSystem > 16)
            {
                Console.WriteLine("Sestination numeral system \"{0}\" is out of the range 2 .. 16", destNumSystem);
                goto End;
            }
            Console.Write("Enter number to convert: ");
            string sourceNum = Console.ReadLine();
            string[] arrayChars = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F".Split(new char[] { ',' });
            double tmpDecimal = 0;
            string destNum = "";

            //convert to decimal system, this conversion has the same rules for all system
            for (int i = 0; i < sourceNum.Length; i++)
            {
                int intFromLeft = Array.IndexOf(arrayChars, sourceNum.Substring(i, 1));
                int powerForNumSystem = sourceNum.Length - i - 1;
                tmpDecimal += intFromLeft * Math.Pow(sourceNumSystem, powerForNumSystem);
            }

            //convert from decimal system in to the destination numerical system
            //this conversion has also the same rules for all destination num systems
            while (tmpDecimal > 0)
            {
                int intFromLeft = (int)(tmpDecimal % destNumSystem);
                string intFromLeftChar = arrayChars[intFromLeft];
                destNum = destNum.Insert(0, intFromLeftChar);
                tmpDecimal = Math.Floor(tmpDecimal / destNumSystem);
            }

            Console.WriteLine("{0} in {1} num system = {2} in {3} num system", sourceNum, sourceNumSystem, destNum, destNumSystem);
        End:;
        }
    }
}
