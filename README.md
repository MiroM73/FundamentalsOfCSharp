<H2>Exercises from book "Fundamentals of Computer Programming with C#"</H2><H3>

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
