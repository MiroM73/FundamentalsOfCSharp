<H2>Exercises from book "Fundamentals of Computer Programming with C#"</H2><H3>
  
<H3>Chapter 7: Arrays</H3>

1. Write a program, which creates an array of 20 elements of type 
integer and initializes each of the elements with a value equals to the 
index of the element multiplied by 5. Print the elements to the console. 

2. Write a program, which reads two arrays from the console and checks 
whether they are equal (two arrays are equal when they are of equal 
length and all of their elements, which have the same index, are equal). 

3. Write a program, which compares two arrays of type char 
lexicographically (character by character) and checks, which one is first 
in the lexicographical order. 

4. Write a program, which finds the maximal sequence of consecutive 
equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}. 

5. Write a program, which finds the maximal sequence of consecutively 
placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}. 

6. Write a program, which finds the maximal sequence of increasing 
elements in an array arr[n]. It is not necessary the elements to be 
consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} -> {2, 4, 6, 8}. 

7. Write a program, which reads from the console two integer numbers N 
and K (K<N) and array of N integers. Find those K consecutive 
elements in the array, which have maximal sum. 

8. Sorting an array means to arrange its elements in an increasing (or 
decreasing) order. Write a program, which sorts an array using the 
algorithm "selection sort". 

9. Write a program, which finds a subsequence of numbers with 
maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> 11 

10. Write a program, which finds the most frequently occurring element in 
an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times). 

11. Write a program to find a sequence of neighbor numbers in an array, 
which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, 
S=11 -> {4, 2, 5}. 

12. Write a program, which creates square matrices like those in the 
figures below and prints them formatted to the console. The size of the 
matrices will be read from the console. See the examples for matrices 
with size of 4 x 4 and make the other sizes in a similar fashion:
<p align="center"> 
<img src="https://github.com/MiroM73/Images/blob/master/c_Sharp_Chap7_Ex12.png">
</p>

    
13. Write a program, which creates a rectangular array with size of n by m 
elements. The dimensions and the elements should be read from the 
console. Find a platform with size of (3, 3) with a maximal sum. 

14. Write a program, which finds the longest sequence of equal string 
elements in a matrix. A sequence in a matrix we define as a set of 
neighbor elements on the same row, column or diagonal. 
<p align="center"> 
<img src="https://github.com/MiroM73/Images/blob/master/c_Sharp_Chap7_Ex14.png">
</p>


15. Write a program, which creates an array containing all Latin letters. 
The user inputs a word from the console and as result the program 
prints to the console the indices of the letters from the word. 

16. Write a program, which uses a binary search in a sorted array of 
integer numbers to find a certain element. 

17. Write a program, which sorts an array of integer elements using a "merge 
sort" algorithm. 

18. Write a program, which sorts an array of integer elements using a "quick 
sort" algorithm. 

19. Write a program, which finds all prime numbers in the range 
[1 ... 10,000,000]. 

20. \* Write a program, which checks whether there is a subset of given 
array of N elements, which has a sum S. The numbers N, S and the array 
values are read from the console. Same number can be used many times. 
Example: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14 -> yes (1 + 2 + 5 + 6 = 14) 

21. Write a program which by given N numbers, K and S, finds K elements out 
of the N numbers, the sum of which is exactly S or says it is not possible. 
Example: {3, 1, 2, 4, 9, 6}, S = 14, K = 3 -> yes (1 + 2 + 4 = 14) 

22. Write a program, which reads an array of integer numbers from the 
console and removes a minimal number of elements in such a way 
that the remaining array is sorted in an increasing order. 
Example: {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5} 

23. Write a program, which reads the integer numbers N and K from the 
console and prints all variations of K elements of the numbers in the 
interval [1 ... N]. Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, 
{2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}. 
24. Write a program, which reads an integer number N from the console and 
prints all combinations of K elements of numbers in range [1 ... N]. 
Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, 
{2, 5}, {3, 4}, {3, 5}, {4, 5}. 

25. \* Write a program, which finds in a given matrix the largest area of 
equal numbers. We define an area in the matrix as a set of neighbor 
cells (by row and column). Here is one example with an area containing 
13 elements with equal value of 3:       
<p align="center"> 
<img src="https://github.com/MiroM73/Images/blob/master/c_Sharp_Chap7_Ex25.png">
</p>  

Examples:   
Pascal’s Triangle (PascalsTriangle.cs)   
Generate and visualize the Pascal’s triangle.   
As we know from mathematics, the first row of the
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

<H3>Chapter 8: Numeral Systems</H3>

1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary 
numeral system.

2. Convert the number 1111010110011110(2) to hexadecimal and decimal 
numeral systems.

3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and 
decimal numeral systems. 

4. Write a program that converts a decimal number to binary one. 

5. Write a program that converts a binary number to decimal one. 

6. Write a program that converts a decimal number to hexadecimal one. 

7. Write a program that converts a hexadecimal number to decimal one. 

8. Write a program that converts a hexadecimal number to binary one. 

9. Write a program that converts a binary number to hexadecimal one. 

10. Write a program that converts a binary number to decimal using the 
Horner scheme. 

11. Write a program that converts Roman digits to Arabic ones. 

12. Write a program that converts Arabic digits to Roman ones. 

13. Write a program that by given N, S, D (2 =< S, D =< 16) converts the number 
N from an S-based numeral system to a D based numeral system. 

14. Try adding up 50,000,000 times the number 0.000001. Use a loop 
and addition (not direct multiplication). Try it with float and double and 
after that with decimal. Do you notice the huge difference in the 
results and speed of calculation? Explain what happens. 

15. \* Write a program that prints the value of the mantissa, the sign of the 
mantissa and exponent in float numbers (32-bit numbers with a 
floating-point according to the IEEE 754 standard). Example: for the 
number -27.25 should be printed: sign = 1, exponent = 10000011, 
mantissa = 10110100000000000000000. 

<H3>Chapter 9: Methods</H3>

1. Write a code that by given name prints on the console "Hello, <name>!"
Example: "Hello, Peter!".

2. Create a method GetMax() with two integer(int) parameters, that
returns maximal of the two numbers.Write a program that reads three
numbers from the console and prints the biggest of them. Use the
GetMax() method you just created. Write a test program that validates
that the methods works correctly.

3. Write a method that returns the English name of the last digit of a
given number.  
Example: for 512 prints "two"; for 1024 -> "four".

4. Write a method that finds how many times certain number can be
found in a given array. Write a program to test that the method works
correctly.

5. Write a method that checks whether an element, from a certain position
in an array is greater than its two neighbors. Test whether the
method works correctly.

6. Write a method that returns the position of the first occurrence of an
element from an array, such that it is greater than its two neighbors
simultaneously. Otherwise the result must be -1.

7. Write a method that prints the digits of a given decimal number in a
reversed order.  
Example: 256, must be printed as 652.

8. Write a method that calculates the sum of two very long positive
integer numbers. The numbers are represented as array digits and
the last digit(the ones) is stored in the array at index 0. Make the
method work for all numbers with length up to 10 000 digits.

9. Write a method that finds the biggest element of an array. Use that
method to implement sorting in descending order.

10. Write a program that calculates and prints the n! for any n in the range [1 … 100].

11. Write a program that solves the following tasks: 
- Put the digits from an integer number into a reversed order.
- Calculate the average of given sequence of numbers.
- Solve the linear equation a * x + b = 0.

  Create appropriate methods for each of the above tasks.
  Make the program show a text menu to the user. By choosing an option
  of that menu, the user will be able to choose which task to be invoked.
  Perform validation of the input data: 
- The integer number must be a positive in the range [1 … 50 000 000]. 
- The sequence of numbers cannot be empty. 
- The coefficient a must be non - zero.

12. Write a method that calculates the sum of two polynomials with integer
coefficients.  
Example: (3x^2 + x - 3) + (x - 1) = (3x^2 + 2x - 4).

13. \* Write a method that calculates the product of two polynomials with
integer coefficients.  
Example: (3x^2 + x - 3) * (x - 1) = (3x^3 - 2x^2 - 4x + 3).  
