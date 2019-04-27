using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise09
    {
        static void Main(string[] args)
        {
            //9.We are given 5 integer numbers. Write a program that finds those
            //subsets whose sum is 0.
            //        Examples:
            //            -If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1 is 0.
            //            -If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets with sum 0.

            Console.WriteLine("EX09: We are given 5 integer numbers. Write a program that finds those\n" +
                "subsets whose sum is 0.\n" +
                "Examples:\n" +
                "   - If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1 is 0.\n" +
                "   - If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets with sum 0.\n");
            Console.Write("Enter the sequence of the five integers delimited by the comma: ");
            string inputNumbers = Console.ReadLine();
            int in1 = int.Parse(inputNumbers.Split(new char[] { ',' })[0]);
            int in2 = int.Parse(inputNumbers.Split(new char[] { ',' })[1]);
            int in3 = int.Parse(inputNumbers.Split(new char[] { ',' })[2]);
            int in4 = int.Parse(inputNumbers.Split(new char[] { ',' })[3]);
            int in5 = int.Parse(inputNumbers.Split(new char[] { ',' })[4]);
            if (in1 + in2 == 0)
            {
                Console.WriteLine($"{in1} + {in2} = 0");
            }
            else if (in1 + in2 + in3 == 0)
            {
                Console.WriteLine($"{in1} + {in2} + {in3} = 0");
            }
            else if (in1 + in2 + in3 + in4  == 0)
            {
                Console.WriteLine($"{in1} + {in2} + {in3} + {in4} = 0");
            }
            else if (in1 + in2 + in3 + in4 + in5 == 0)
            {
                Console.WriteLine($"{in1} + {in2} + {in3} + {in4} + {in5} = 0");
            }
            else if (in2 + in3 == 0)
            {
                Console.WriteLine($"{in2} + {in3} = 0");
            }
            else if (in2 + in3 + in4 == 0)
            {
                Console.WriteLine($"{in2} + {in3} + {in4} = 0");
            }
            else if (in2 + in3 + in4 + in5 == 0)
            {
                Console.WriteLine($"{in2} + {in3} + {in4} + {in5} = 0");
            }
            else if (in3 + in4 == 0)
            {
                Console.WriteLine($"{in3} + {in4} = 0");
            }
            else if (in3 + in4 + in5 == 0)
            {
                Console.WriteLine($"{in3} + {in4} + {in5} = 0");
            }
            else if (in4 + in5 == 0)
            {
                Console.WriteLine($"{in4} + {in5} = 0");
            }
            else
            {
                Console.WriteLine("There is not a sequence of the numbers which equeals zero!");
            }
        }
    }
}
