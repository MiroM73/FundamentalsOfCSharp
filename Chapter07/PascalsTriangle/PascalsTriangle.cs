﻿using System;

namespace Chapter07
{
    class PascalsTriangle
    {
        static void Main(string[] args)
        {
            /*
            Pascal’s Triangle – Example
            In the next example we will use a jagged array to generate and visualize the
            Pascal’s triangle. As we know from mathematics, the first row of the
            triangle contains the number 1 and each next number is generated by sum of
            the two numbers on the row above it. The Pascal’s triangle looks like this: 
                    1
                  1   1
                1   2   1
              1   3   3   1
            1   4   6   4   1
                . . .

            To have a Pascal’s triangle with a given height, for example 12, we allocate a
            jagged array triangle[][], which contains 1 element on the zero row, 2 – 
            on first, 3 – on second and so on. First we initialize triangle[0][0] = 1 and
            the rest of the cells will have a default value than 0 by allocation. Then we
            loop through the rows and from row we will get the values for row + 1. It works
            with nested for loop through the columns on the current row and the
            following Pascal definitions for values in the triangle: we add the value of the
            current cell of the current row(triangle[row][col]) to the cell below
            (triangle[row + 1][col]) and to the cell below on the right(triangle
            [row + 1][col + 1]). We print using an appropriate number of spaces 
            (using method PadLeft () of class String), because we want the result to be aligned.
            Here is the code of the described algorithm:
            */

            const int HEIGHT = 12;

            // Allocate the array in a triangle form 

            long[][] triangle = new long[HEIGHT + 1][];

            for (int row = 0; row<HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }

            // Calculate the Pascal's triangle 
            triangle[0][0] = 1;
            for (int row = 0; row<HEIGHT - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            // Print the Pascal's triangle 
            for (int row = 0; row<HEIGHT; row++)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
