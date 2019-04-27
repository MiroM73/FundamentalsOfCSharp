<H2>Exercises from book "Fundamentals of Computer Programming with C#"</H2>
  Official Web Site
  https://introprogramming.info/

<H3>Chapter 1: Introduction to Programming</H3>

1. Install and make yourself familiar with Microsoft Visual Studio and 
Microsoft Developer Network (MSDN) Library Documentation. 

2. Find the description of the System.Console class in the standard .NET 
API documentation (MSDN Library). 

3. Find the description of the System.Console.WriteLine() method and its 
different possible parameters in the MSDN Library. 

4. Compile and execute the sample program from this chapter using the 
command prompt (the console) and Visual Studio. 

5. Modify the sample program to print a different greeting, for example 
"Good Day!". 

6. Write a console application that prints your first and last name on the console. 

7. Write a program that prints the following numbers on the console 1, 
101, 1001, each on a new line. 

8. Write a program that prints on the console the current date and time. 

9. Write a program that prints the square root of 12345. 

10. Write a program that prints the first 100 members of the sequence 
2, -3, 4, -5, 6, -7, 8. 

11. Write a program that reads your age from the console and prints your 
age after 10 years. 

12. Describe the difference between C# and the .NET Framework. 

13. Make a list of the most popular programming languages. How are they 
different from C#? 

14. Decompile the example program from exercise 5. 

<H3>Chapter 5: Conditional Statements</H3>

1. Write an if-statement that takes two integer variables and exchanges
their values if the first one is greater than the second one.

2. Write a program that shows the sign ( + or -) of the product of three real
numbers, without calculating it.Use a sequence of if operators.

3. Write a program that finds the biggest of three integers, using nested
if statements.

4. Sort 3 real numbers in descending order. Use nested if statements.

5. Write a program that asks for a digit (0 - 9), and depending on the input,
shows the digit as a word (in English). Use a switch statement.

6. Write a program that gets the coefficients a, b and c of a quadratic
equation: ax2 + bx + c, calculates and prints its real roots(if they exist). 
Quadratic equations may have 0, 1 or 2 real roots. 

7. Write a program that finds the greatest of given 5 numbers.
prerobene na najdenie najvacsieho cisla zo zadanych

8. Write a program that, depending on the user’s choice, inputs int, double
or string variable. If the variable is int or double, the program
increases it by 1.If the variable is a string, the program appends "\*" at
the end.Print the result at the console. Use switch statement.

9. We are given 5 integer numbers. Write a program that finds those
subsets whose sum is 0.\
Examples:
- If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1 is 0.
- If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets with sum 0.

10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules: 
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error message.

11. \* Write a program that converts a number in the range [0…999] to
words, corresponding to the English pronunciation.\
Examples:
- 0-- > "Zero"
- 12-- > "Twelve"
- 98-- > "Ninety eight"
- 273-- > "Two hundred seventy three"
- 400-- > "Four hundred"
- 501-- > "Five hundred and one"
- 711-- > "Seven hundred and eleven"

<H3>Chapter 6: Loops</H3>

1. Write a program that prints on the console the numbers from 1 to N. 
   The number N should be read from the standard input.

2. Write a program that prints on the console the numbers from 1 to N, 
   which are not divisible by 3 and 7 simultaneously.The number N
   should be read from the standard input.
   
3. Write a program that reads from the console a series of integers and 
   prints the smallest and largest of them.
   
4. Write a program that prints all possible cards from a standard deck 
   of cards, without jokers(there are 52 cards: 4 suits of 13 cards). 

5. Write a program that reads from the console number N and print the sum 
   of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
   13, 21, 34, 55, 89, 144, 233, 377, … 

6. Write a program that calculates N!/ K! for given N and K(1 < K < N).

7. Write a program that calculates N!*K!/ (N - K)! for given N and K
   (1 < K < N).

8. In combinatorics, the Catalan numbers are calculated by the following
   formula: 
   <p align="left"> 
   <img src="https://github.com/MiroM73/Images/blob/master/c_Sharp_Chap6_Ex8.png"  width="200">
   </p>         
   for n ≥ 0. Write a program that calculates the n-th Catalan number by given n.

9. Write a program that for a given integers n and x, calculates the sum: 
   <p align="left"> 
   <img src="https://github.com/MiroM73/Images/blob/master/c_Sharp_Chap6_Ex9.png"  width="200">
   </p>

10. Write a program that reads from the console a positive integer number
    N(N < 20) and prints a matrix of numbers as on the figures below: 
    <p align="left"> 
    <img src="https://github.com/MiroM73/Images/blob/master/c_Sharp_Chap6_Ex10.png"  width="250">
    </p>
    
11. Write a program that calculates with how many zeroes the factorial of 
    a given number ends.
    
    Examples: 
    
        N = 10->N! = 3628800-> 2
        N = 20->N! = 2432902008176640000-> 4

12. Write a program that converts a given number from decimal to binary
    notation(numeral system).

13. Write a program that converts a given number from binary to decimal
    notation.

14. Write a program that converts a given number from decimal to
    hexadecimal notation.

15. Write a program that converts a given number from hexadecimal to
    decimal notation.

16. Write a program that by a given integer N prints the numbers from 1 to N 
    in random order.

17. Write a program that given two numbers finds their greatest common
    divisor(GCD) and their least common multiple(LCM).You may use 
    the formula LCM(a, b) = | a * b | / GCD(a, b).

18. \* Write a program that for a given number n, outputs a matrix in the
    form of a spiral:     
    
    <p align="left"> 
    <img src="https://github.com/MiroM73/Images/blob/master/c_Sharp_Chap6_Ex18.png"  width="300">
    </p>

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

<H3>Chapter 10: Recursion</H3>

1. Write a program to simulate n nested loops from 1 to n. 

2. Write a program to generate all variations with duplicates of n 
elements class k.
>     Sample input: 
>         n = 3 
>         k = 2 
>
>     Sample output: 
>         (1 1), (1 2), (1 3), (2 1), (2 2), (2 3), (3 1), (3 2), (3 3)
>Think about and implement an iterative algorithm for the same task. 

3. Write a program to generate and print all combinations with 
duplicates of k elements from a set with n elements. 
>     Sample input: 
>         n = 3 
>         k = 2 
>
>     Sample output: 
>         (1 1), (1 2), (1 3), (2 2), (2 3), (3 3) 
> Think about and implement an iterative algorithm for the same task. 

4. You are given a set of strings. Write a recursive program, which 
generates all subsets, consisting exactly k strings chosen among the 
elements of this set. 
>     Sample input: 
>         strings = {'test', 'rock', 'fun'} 
>         k = 2 
>
>     Sample output: 
>         (test rock), (test fun), (rock fun) 
> Think about and implement an iterative algorithm as well. 

5. Write a recursive program, which prints all subsets of a given set of 
N words. 
>     Example input: 
>         words = {'test', 'rock', 'fun'} 
>
>     Example output: 
>         (), (test), (rock), (fun), (test rock), (test fun), (rock fun), (test rock fun) 
> Think about and implement an iterative algorithm for the same task. 

6. Implement the merge-sort algorithm recursively. In it the initial array 
is divided into two equal in size parts, which are sorted (recursively via 
merge-sort) and after that the two sorted parts are merged in order to 
get the whole sorted array. 

7. Write a recursive program, which generates and prints all permutations 
of the numbers 1, 2, …, n, for a given integer n. 
>     Example input: 
>         n = 3 
>
>     Example output: 
>         (1, 2, 3), (1, 3, 2), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1) 
> Try to find an iterative solution for generating permutations. 

8. You are given an array of integers and a number N. Write a recursive 
program that finds all subsets of numbers in the array, which have a 
sum N. For example, if we have the array {2, 3, 1, -1} and N=4, we can 
obtain N=4 as a sum in the following two ways: 4=2+3-1; 4=3+1. 

9. You are given an array of positive integers. Write a program that checks 
whether there is one or more numbers in the array (subset), whose 
sum is equal to S. Can you solve the task efficiently for large arrays? 

10. You are given a matrix with passable and impassable cells. Write a 
recursive program that finds all paths between two cells in the matrix. 

11. Implement the algorithm BFS (breadth-first search) for finding the 
shortest path in a labyrinth. 

12. Modify the previous program to check whether a path exists between 
two cells without finding all possible paths. Test the program with a 
matrix 100x100 filled only with passable cells. 

13. You are given a matrix with passable and impassable cells. Write a 
program that finds the largest area of neighboring passable cells. 

14. Write a recursive program that traverses the whole hard disk C:\ 
recursively and prints all folders and files. 

<H3>Chapter 11: Creating and Using Objects</H3>

1. Write a program, which reads from the console a year and checks if it is 
a leap year. 

2. Write a program, which generates and prints on the console 10 random 
numbers in the range [100, 200]. 

3. Write a program, which prints, on the console which day of the week is 
today. 

4. Write a program, which prints on the standard output the count of days, 
hours, and minutes, which have passes since the computer is 
started until the moment of the program execution. For the 
implementation use the class Environment. 

5. Write a program which by given two sides finds the hypotenuse of a 
right triangle. Implement entering of the lengths of the sides from the 
standard input, and for the calculation of the hypotenuse use methods of 
the class Math. 

6. Write a program which calculates the area of a triangle with the 
following given:\
- three sides; 
- side and the altitude to it; 
- two sides and the angle between them in degrees. 

7. Define your own namespace CreatingAndUsingObjects and place in it 
two classes Cat and Sequence, which we used in the examples of the 
current chapter. Define one more namespace and make a class, which 
calls the classes Cat and Sequence, in it. 

8. Write a program which creates 10 objects of type Cat, gives them names 
CatN, where N is a unique serial number of the object, and in the end call 
the method SayMiau() for each of them. For the implementation use the 
namespace CreatingAndUsingObjects. 

9. Write a program, which calculates the count of workdays between 
the current date and another given date after the current (inclusive). 
Consider that workdays are all days from Monday to Friday, which are not 
public holidays, except when Saturday is a working day. The program 
should keep a list of predefined public holidays, as well as a list of 
predefined working Saturdays. 

10. You are given a sequence of positive integer numbers given as string 
of numbers separated by a space. Write a program, which calculates 
their sum. Example: "43 68 9 23 318" -> 461. 

11. Write a program, which generates a random advertising message for 
some product. The message has to consist of laudatory phrase, followed 
by a laudatory story, followed by author (first and last name) and city, 
which are selected from predefined lists. For example, let’s have the 
following lists:
- Laudatory phrases: {"The product is excellent.", "This is a great 
product.", "I use this product constantly.", "This is the best product 
from this category."}. 
- Laudatory stories: {"Now I feel better.", "I managed to change.", 
"It made some miracle.", "I can’t believe it, but now I am feeling 
great.", "You should try it, too. I am very satisfied."}. 
- First name of the author: {"Dayan", "Stella", "Hellen", "Kate"}. 
- Last name of the author: {"Johnson", "Peterson", "Charls"}. 
- Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}.\
Then the program would print randomly generated advertising message 
like the following:\
I use this product constantly. You should try it, too. I am 
very satisfied. -- Hellen Peterson, Berlin 

12. \* Write a program, which calculates the value of a given numeral 
expression given as a string. The numeral expression consists of: 
- real numbers, for example 5, 18.33, 3.14159, 12.6; 
- arithmetic operations: +, -, \*, / (with their standard priorities); 
- mathematical functions: ln(x), sqrt(x), pow(x, y); 
- brackets for changing the priorities of the operations: ( and ).\
\
Note that the numeral expressions have priorities, for example the expression:\
-1 + 2 + 3 * 4 - 0.5 = (-1) + 2 + (3 * 4) - 0.5 = 12.5. 

<H3>Chapter 12: Exception Handling</H3>

1. Find out all exceptions in the System.IO.IOException hierarchy. 

2. Find out all standard exceptions that are part of the hierarchy holding 
the class System.IO.FileNotFoundException. 

3. Find out all standard exceptions from System.ApplicationException 
hierarchy. 

4. Explain the concept of exceptions and exception handling, when they 
are used and how to catch exceptions. 

5. Explain when the statement try-finally is used. Explain the relationship 
between the statements try-finally and using. 

6. Explain the advantages when using exceptions. 

7. Write a program that takes a positive integer from the console and prints 
the square root of this integer. If the input is negative or invalid print 
"Invalid Number" in the console. In all cases print "Good Bye". 

8. Write a method ReadNumber(int start, int end) that reads an integer 
from the console in the range [start…end]. In case the input integer is 
not valid or it is not in the required range throw appropriate exception. 
Using this method, write a program that takes 10 integers a1, a2, …, a10 
such that 1 < a1 < … < a10 < 100. 

9. Write a method that takes as a parameter the name of a text file, reads 
the file and returns its content as string. What should the method 
do if and exception is thrown? 

10. Write a method that takes as a parameter the name of a binary file, 
reads the content of the file and returns it as an array of bytes. Write
a method that writes the file content to another file. Compare both files. 

11. Search for information in Internet and define your own class for exception 
FileParseException. The exception has to contain the name of the 
processed file and the number of the row where the problem is occurred. 
Add appropriate constructors in the exception. Write a program that 
reads integers from a text file. If the during reading a row does not 
contain an integer throw FileParseException and pass it to the calling 
method. 

12. Write a program that gets from the user the full path to a file (for 
example C:\Windows\win.ini), reads the content of the file and prints it 
to the console. Find in MSDN how to us the System.IO.File. 
ReadAllText(…) method. Make sure all possible exceptions will be 
caught and a user-friendly message will be printed on the console. 

13. Write a program to download a file from Internet by given URL, e.g. 
http://introprogramming.info/wp-content/themes/introprograming_en/images/Intro-Csharp-Book-front-cover-big_en.png. 

<H3>Chapter 13: Strings and Text Processing</H3>

1. Describe the strings in C#. What is typical for the string type? 
Explain which the most important methods of the string class are. 

2. Write a program that reads a string, reverse it and prints it to the 
console. For example: "introduction"  "noitcudortni". 

3. Write a program that checks whether the parentheses are placed 
correctly in an arithmetic expression. Example of expression with 
correctly placed brackets: ((a+b)/5-d). Example of an incorrect 
expression: )(a+b)). 

4. How many backslashes you must specify as an argument to the method 
Split(…) in order to split the text by a backslash?\
Example: one\two\three. 

5. Write a program that detects how many times a substring is contained in 
the text. For example, let’s look for the substring "in" in the text: 
We are living in a yellow submarine. We don't have anything 
else. Inside the submarine is very tight. So we are drinking 
all the day. We will move out of it in 5 days. 
The result is 9 occurrences. 

6. A text is given. Write a program that modifies the casing of letters to 
uppercase at all places in the text surrounded by \<upcase> and 
\</upcase> tags. Tags cannot be nested.\
Example:\
We are living in a \<upcase>yellow submarine\</upcase>. We 
don't have \<upcase>anything\</upcase> else.\
Result:\
We are living in a YELLOW SUBMARINE. We don't have ANYTHING 
else. 

7. Write a program that reads a string from the console (20 characters 
maximum) and if shorter complements it right with "\*" to 20 characters. 

8. Write a program that converts a given string into the form of array of 
Unicode escape sequences in the format used in the C# language. 
Sample input: "Test". Result: "\u0054\u0065\u0073\u0074". 

9. Write a program that encrypts a text by applying XOR (excluding or) 
operation between the given source characters and given cipher code. 
The encryption should be done by applying XOR between the first letter 
of the text and the first letter of the code, the second letter of the text 
and the second letter of the code, etc. until the last letter of the code, 
then goes back to the first letter of the code and the next letter of the 
text. Print the result as a series of Unicode escape characters \xxxx. 
Sample source text: "Test". Sample cipher code: "ab". The result should 
be the following: "\u0035\u0007\u0012\u0016". 

10. Write a program that extracts from a text all sentences that contain 
a particular word. We accept that the sentences are separated from 
each other by the character "." and the words are separated from one 
another by a character which is not a letter. Sample text: 
We are living in a yellow submarine. We don't have anything 
else. Inside the submarine is very tight. So we are drinking 
all the day. We will move out of it in 5 days.\
Sample result:\
We are living in a yellow submarine.\
We will move out of it in 5 days. 

11. A string is given, composed of several "forbidden" words separated by 
commas. Also a text is given, containing those words. Write a program 
that replaces the forbidden words with asterisks. Sample text: 
Microsoft announced its next generation C# compiler today. 
It uses advanced parser and special optimizer for the 
Microsoft CLR.\
Sample string containing the forbidden words: "C#,CLR,Microsoft".\
Sample result:\
********* announced its next generation ** compiler today.\
It uses advanced parser and special optimizer for the\
********* \*\*\*. 

12. Write a program that reads a number from console and prints it in 15-
character field, aligned right in several ways: as a decimal number, 
hexadecimal number, percentage, currency and exponential (scientific) 
notation. 

13. Write a program that parses an URL in following format:\
[protocol]://[server]/[resource]\
It should extract from the URL the protocol, server and resource parts.\
For example, when http://www.cnn.com/video is passed, the result is:\
[protocol]="http"\
[server]="www.cnn.com"\
[resource]="/video" 

14. Write a program that reverses the words in a given sentence without 
changing punctuation and spaces. For example: "C# is not C++ and 
PHP is not Delphi" -> "Delphi not is PHP and C++ not is C#". 

15. A dictionary is given, which consists of several lines of text. Each line 
consists of a word and its explanation, separated by a hyphen: 
.NET – platform for applications from Microsoft 
CLR – managed execution environment for .NET 
namespace – hierarchical organization of classes 
Write a program that parses the dictionary and then reads words from 
the console in a loop, gives an explanation for it or writes a message 
on the console that the word is not into the dictionary. 

16. Write a program that replaces all hyperlinks in a HTML document 
consisting of \<a href="…">…\</a> and hyperlinks in "forum" style, which 
look like [URL=…]…[/URL]. 
		
    ```html
	Sample text:
	<p>Please visit <a href="http://softuni.org">our site</a> to 
	choose a training course. Also visit <a href= 
	"http://forum.softuni.org">our forum</a> to discuss the 
	courses.</p> 
    ```

    ```html
	Sample result: 
	<p>Please visit [URL=http://softuni.org]our site[/URL] to 
	choose a training course. Also visit [URL= 
	http://forum.softuni.org]our forum[/URL] to discuss the 
	courses.</p> 
    ```

17. Write a program that reads two dates entered in the format 
"day.month.year" and calculates the number of days between them. 
Enter the first date: 27.02.2006 
Enter the second date: 3.03.2006 
Distance: 4 days 

18. Write a program that reads the date and time entered in the format 
"day.month.year hour:minutes:seconds" and prints the date and time 
after 6 hours and 30 minutes in the same format. 

19. Write a program that extracts all e-mail addresses from a text. These 
are all substrings that are limited on both sides by text end or separator 
between words and match the shape \<sender>@\<host>…\<domain>. 
Sample text:\
Please contact us by phone (+001 222 222 222) or by email at 
example@gmail.com or at test.user@yahoo.co.uk.\
This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.\
Extracted e-mail addresses from the sample text:\
example@gmail.com\
test.user@yahoo.co.uk 

20. Write a program that extracts from a text all dates written in format 
DD.MM.YYYY and prints them on the console in the standard format for 
Canada. Sample text:\
I was born at 14.06.1980. My sister was born at 3.7.1984. In 
5/1999 I graduated my high school. The law says (see section 
7.3.12) that we are allowed to do this (section 7.4.2.9).\
Extracted dates from the sample text:\
14.06.1980\
3.7.1984 

21. Write a program that extracts from a text all words which are 
palindromes, such as ABBA", "lamal", "exe". 

22. Write a program that reads a string from the console and prints in 
alphabetical order all letters from the input string and how many 
times each one of them occurs in the string. 

23. Write a program that reads a string from the console and prints in 
alphabetical order all words from the input string and how many 
times each one of them occurs in the string. 

24. Write a program that reads a string from the console and replaces every 
sequence of identical letters in it with a single letter (the repeating 
letter). Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa". 

25. Write a program that reads a list of words separated by commas from the 
console and prints them in alphabetical order (after sorting). 

26. Write a program that extracts all the text without any tags and 
attribute values from an HTML document. 
	```html
    Sample text:
	<html> 
	  <head><title>News</title></head> 
	  <body><p><a href="http://softuni.org">Software 
	    University</a>aims to provide free real-world practical 
	    training for young people who want to turn into 
	    skillful software engineers.</p></body> 
	</html> 
	```
    >Sample result:
    > 
    >News\
    >Software University aims to provide free real-world\
    >practical training for young people who want to turn into\
    >skillful software engineers. 

