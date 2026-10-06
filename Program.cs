// This Program.cs file contains the main entry point of the C# application. 
// It demonstrates various C# concepts such as variables, 
// data types, constants, user input, type casting, and operators. 
// The code includes examples of how to declare and use variables, 
// perform arithmetic operations, and interact with the user through console input and output.

//in new version of C# 9.0 and later, you can write code directly in the file without needing 
//to wrap it in a class or method.

//we can write code without name space ,class,method this console.WriteLine("Hello World!"); working
//============================================================================================


// using MyFirstApp;
// Console.WriteLine("Welcome to the Calculator App!");
// Calculator calculator = new Calculator();
// calculator.SayHello("User");
// int result = calculator.Add(5, 3);
// Console.WriteLine($"The result of adding 5 and 3 is: {result}");

//=======================================================================
//W3 school C# Syntax
// using System;
// namespace HelloWorld
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.WriteLine("Hello World!");
//     }
//   }
//}
//=======================================================================
//without name space ,class,method this console.WriteLine("Hello World!"); working
//because of top-level statements in C# 9.0 and later, which allows you to write code directly 
// in the file without needing to wrap it in a class or method. This feature simplifies the 
// code for small programs and scripts, making it easier to read and write.
//=======================================================================

Console.Write("Hello World! ");
Console.Write("I will print on the same line.");
// Without a newline character, the next output will continue on the same line - Write()
// With a newline character, the next output will start on a new line - WriteLine()

//=======================================================================
Console.WriteLine(3 + 3);
//can also use string interpolation to print the result of the addition
//=======================================================================
//Commenting in C#

// Single-line comment
/*
    This is a multi-line comment.
    It can span multiple lines.
*/

//=======================================================================
//C# Variables and Data Types
// In C#, variables are used to store data. Each variable has a specific data type that
// determines the kind of data it can hold. Here are some common data types in C#:

// 1. int: Represents integer values (whole numbers).
int myInteger = 42; // Example of an integer variable
// 2. double: Represents floating-point numbers (numbers with decimal points).
double myDouble = 3.14; // Example of a double variable
// 3. string: Represents a sequence of characters (text).
string myString = "Hello, World!"; // Example of a string variable
// 4. bool: Represents a boolean value (true or false).
bool myBool = true; // Example of a boolean variable
// 5. char: Represents a single character.
char myChar = 'A'; // Example of a character variable

Console.WriteLine($"Integer: {myInteger}, Double: {myDouble}, String: {myString}, Boolean: {myBool}, Char: {myChar}");

//=======================================================================
// C# Constants
// In C#, a constant is a variable whose value cannot be changed after it has been assigned.
const int MY_CONSTANT = 100; // Example of a constant
Console.WriteLine($"Constant: {MY_CONSTANT}");
//MY_CONSTANT = 200; // This will cause a compile-time error because constants cannot be reassigned.
//const string GREETING; //Note: You cannot declare a constant variable without assigning the value.
//If you do, an error will occur: A const field requires a value to be provided.
//=======================================================================
//C# Display Variables

string name = "Alice";
Console.WriteLine($"Hello, {name}!"); // Using string interpolation
Console.WriteLine("Hello, " + name + "!"); // Using string concatenation

string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName; // Concatenating strings
Console.WriteLine($"Full Name: {fullName}"); // Displaying the full name using

int x = 10;
int y = 20;
Console.WriteLine(x + y); // Displaying the sum of two integers

int a = 20 , b = 30 , c = 40; // use commas to declare multiple variables of the same type in a single line
Console.WriteLine($"Sum: {a + b + c}"); // Displaying the sum of three integers

int num1 , num2 , num3; // Declaring multiple variables of the same type in a single line
num1 = 5; // Assigning values to the variables
num2 = 10;
num3 = 15;
Console.WriteLine($"Sum: {num1 + num2 + num3}"); // Displaying the sum of three integers

int p , q , r ;
p = q = r = 50; // Assigning the same value to multiple variables in a single line
Console.WriteLine($"Values: p={p}, q={q}, r={r}");

//=======================================================================
//C# identifiers

// In C#, identifiers are names used to identify variables, methods, classes, and other elements
// Names can contain letters, digits and the underscore character (_)
int _myVariable = 10; // Valid identifier
int myVariable2 = 20; // Valid identifier
int my_variable = 30; // Valid identifier
int myVariable3 = 40; // Valid identifier

// Names must begin with a letter or underscore
int myVariable4 = 50; // Valid identifier
int _myVariable5 = 60; // Valid identifier
//int 2myVariable = 70; // Invalid identifier (cannot start with a digit)

// Names should start with a lowercase letter, and cannot contain whitespace
int myVariable6 = 80; // Valid identifier
int MyVariable7 = 90; // Valid identifier, but not recommended (starts with uppercase letter)
//int my Variable8 = 100; // Invalid identifier (contains whitespace)

// Names are case-sensitive ("myVar" and "myvar" are different variables)
string myVar = "Hello";
string myvar = "World";

// Reserved words (like C# keywords, such as int or double) cannot be used as names
//string myDouble = "This is also a string"; // Valid identifier, but not recommended (uses reserved word "double")

// Good
int minutesPerHour = 60;

// OK, but not so easy to understand what m actually is
int m = 60;


//=======================================================================
//C# Scientific Numbers
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);

//=======================================================================
//C# Type Casting
// Type casting is a way to convert a variable from one data type to another. 
// In C#, there are two main types of type casting: implicit and explicit.

// Implicit Casting (automatically) - converting a smaller type to a larger type size
// This is done automatically by the C# compiler.
//char -> int -> long -> float -> double
int myInt = 9;
double myDouble2 = myInt; // Implicit casting: int to double
Console.WriteLine(myDouble2); // Outputs 9

// Explicit Casting (manually) - converting a larger type to a smaller size type
// This requires a cast operator (type) to be specified.
double myDouble1 = 9.75;
int myInt2 = (int)myDouble1; // Explicit casting: double to int
Console.WriteLine(myInt2); // Outputs 9

//=======================================================================
//Type convertion methods
// C# provides several methods for converting between different data types.
// 1. Convert.ToInt32(): Converts a value to a 32-bit signed integer.
double doubleValue = 9.75;
int intValue = Convert.ToInt32(doubleValue); // Converts double to int
Console.WriteLine(intValue); // Outputs 10 (rounds to the nearest integer)

// 2. Convert.ToDouble(): Converts a value to a double-precision floating-point number.
int intValue2 = 10;
double doubleValue2 = Convert.ToDouble(intValue2); // Converts int to double
Console.WriteLine(doubleValue2); // Outputs 10.0

// 3. Convert.ToString(): Converts a value to its string representation.
int intValue3 = 100;
string stringValue = Convert.ToString(intValue3); // Converts int to string
Console.WriteLine(stringValue); // Outputs "100"

// 4. Convert.ToBoolean(): Converts a value to a boolean (true or false).
int intValue4 = 1;
bool boolValue = Convert.ToBoolean(intValue4); // Converts int to bool
Console.WriteLine(boolValue); // Outputs True (1 is considered true)

// 5. Convert.ToChar(): Converts a value to a Unicode character.
int intValue5 = 65;
char charValue = Convert.ToChar(intValue5); // Converts int to char
Console.WriteLine(charValue); // Outputs 'A' (Unicode character for 65)

//=======================================================================
//C# User Input
// In C#, you can get user input from the console using the Console.ReadLine() method

Console.Write("Enter your name: ");
string userName = Console.ReadLine(); // Reads a line of text from the console
Console.WriteLine($"Hello, {userName}!"); // Greets the user by name

//The Console.ReadLine() method returns a string. Therefore, 
//you cannot get information from another data type, such as int.
//The following program will cause an error:
Console.Write("Enter your age: ");
//int age = Console.ReadLine(); - > Cannot implicitly convert type 'string' to 'int'CS0029
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You are {age} years old.");

//=======================================================================
//C# Operators
//Arithmetic Operators
// In C#, operators are symbols that perform operations on variables and values.
int numA = 10 + 5; // Addition operator
Console.WriteLine($"numA: {numA}"); // Outputs: numA: 15
int numB = 10 - 5; // Subtraction operator
Console.WriteLine($"numB: {numB}"); // Outputs: numB: 5
int numC = 10 * 5; // Multiplication operator
Console.WriteLine($"numC: {numC}"); // Outputs: numC: 50
double numD = 10.0 / 3.0; // Division operator
Console.WriteLine($"numD: {numD}"); // Outputs: numD: 3.3333333333333335

// + operator can also be used to concatenate strings
string str1 = "Hello, ";
string str2 = "World!";
string str3 = str1 + str2; // Concatenation operator
Console.WriteLine($"str3: {str3}"); // Outputs: str3: Hello, World!

//+ operator can also be used to add numbers and concatenate strings in the same expression
int numE = 10;
string str4 = "The result is: " + (numE + 5); // Concatenation and addition
Console.WriteLine($"str4: {str4}"); // Outputs: str4: The result is: 15

//+ operator can also be used to concatenate strings and numbers in the same expression
int numF = 20;
string str5 = "The result is: " + numF; // Concatenation and addition
Console.WriteLine($"str5: {str5}"); // Outputs: str5: The result is: 20

//=======================================================================
//Assignment Operators
// In C#, assignment operators are used to assign values to variables.

int x1 = 10; // Assigns the value 10 to x1
x1 += 5; // Adds 5 to x1 (x1 = x1 + 5)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 15
x1 -= 3; // Subtracts 3 from x1 (x1 = x1 - 3)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 12
x1 *= 2; // Multiplies x1 by 2 (x1 = x1 * 2)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 24
x1 /= 4; // Divides x1 by 4 (x1 = x1 / 4)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 6
x1 %= 3; // Assigns the remainder of x1 divided by 3 to x1 (x1 = x1 % 3)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 0
x1 &= 2; // Performs a bitwise AND operation on x1 and 2 (x1 = x1 & 2)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 0
x1 |= 1; // Performs a bitwise OR operation on x1 and 1 (x1 = x1 | 1)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 1
x1 ^= 3; // Performs a bitwise XOR operation on x1 and 3 (x1 = x1 ^ 3)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 2
x1 <<= 1; // Performs a left shift operation on x1 by 1 (x1 = x1 << 1)
Console.WriteLine($"x1: {x1}"); // Outputs: x1: 4
x1 >>= 2; // Performs a right shift operation on x1 by 2 (x1 = x1 >> 2)
Console.WriteLine($"x1: {x1}");

//=======================================================================
//Comparison Operators
// In C#, comparison operators are used to compare two values.

bool isEqual = (5 == 5); // Equal to
bool isNotEqual = (5 != 3); // Not equal to
bool isGreaterThan = (5 > 3); // Greater than
bool isLessThan = (3 < 5); // Less than
bool isGreaterThanOrEqual = (5 >= 5); // Greater than or equal to
bool isLessThanOrEqual = (3 <= 5); // Less than or equal to

Console.WriteLine($"isEqual: {isEqual}, isNotEqual: {isNotEqual}, isGreaterThan: {isGreaterThan}, isLessThan: {isLessThan}, isGreaterThanOrEqual: {isGreaterThanOrEqual}, isLessThanOrEqual: {isLessThanOrEqual}");

//=======================================================================
//Logical Operators
// In C#, logical operators are used to combine conditional statements.

bool isTrue = (5 == 5) && (3 < 5); // AND operator
bool isFalse = (5 == 3) || (3 > 5); // OR operator
bool isNotTrue = !(5 == 3); // NOT operator

Console.WriteLine($"isTrue: {isTrue}, isFalse: {isFalse}, isNotTrue: {isNotTrue}");

//=======================================================================
//C# Math
// In C#, the Math class provides methods for performing mathematical operations.
double number = 9.0;
double squareRoot = Math.Sqrt(number); // Calculates the square root
double power = Math.Pow(2, 3); // Calculates 2 raised to the power
Console.WriteLine($"squareRoot: {squareRoot}, power: {power}");

Math.Max(5, 10); // Returns the larger of two numbers
Math.Min(5, 10); // Returns the smaller of two numbers
Math.Sqrt(16); // Returns the square root of a number
Math.Abs(-10); // Returns the absolute value of a number
Math.Round(3.7); // Rounds a number to the nearest integer
Console.WriteLine($"Max: {Math.Max(5, 10)}, Min: {Math.Min(5, 10)}, Sqrt: {Math.Sqrt(16)}, Abs: {Math.Abs(-10)}, Round: {Math.Round(3.7)}");

//=======================================================================
//C# Strings
// In C#, strings are used to represent text. A string is a sequence of characters.
string greeting = "Hello, World!"; // Example of a string variable
Console.WriteLine($"greeting: {greeting}");
string greeting2 = "Hello, C#!"; // Example of a string variable
Console.WriteLine($"greeting2: {greeting2}");
Console.WriteLine($"Length of greeting: {greeting.Length}"); // Outputs the length of the string
Console.WriteLine($"Uppercase: {greeting.ToUpper()}"); // Converts the string to uppercase
Console.WriteLine($"Lowercase: {greeting.ToLower()}"); // Converts the string to lowercase
string substring = greeting.Substring(7, 5); // Extracts a substring from the string -> 7 is the starting index and 5 is the length of the substring
Console.WriteLine($"Substring: {substring}"); // Outputs: Substring: World

//string concatenation
string firstName1 = "John";
string lastName1 = "Doe";
string fullName1 = firstName1 + " " + lastName1; // Concatenates two strings with a space in between
Console.WriteLine($"Full Name: {fullName1}"); // Outputs: Full Name: John Doe

//using Concat method
string name1 = string.Concat(firstName1, " ", lastName1); // Concatenates two strings with a space in between using the Concat method
Console.WriteLine($"Name: {name1}"); // Outputs: Name: John Doe

//========================================================================
//String Interpolation
// In C#, string interpolation is a way to create formatted strings by embedding
//  expressions inside string literals.
string firstName2 = "Jane";
string lastName2 = "Smith";
string fullName2 = $"{firstName2} {lastName2}"; // Using string interpolation to concatenate strings
Console.WriteLine($"Full Name: {fullName2}"); // Outputs: Full Name: Jane Smith
//Also note that you have to use the dollar sign ($) when using the string interpolation method.
//String interpolation was introduced in C# version 6.

//============================================================

//Access strings
string myString1 = "Hello";
Console.WriteLine(myString1[0]); // Outputs: H (accessing the first character of the string)
Console.WriteLine(myString1[1]); //Outputs: e
Console.WriteLine(myString1.IndexOf("e"));

//Another useful method is Substring(), which extracts the characters from a string, 
//starting from the specified character position/index, and returns a new string.
//This method is often used together with IndexOf() to get the specific character position:
string myString2 = "Hello, World!";
// Get the index of the comma
int commaIndex = myString2.IndexOf(",");
// Extract the substring starting from the character after the comma
string substring1 = myString2.Substring(commaIndex + 1); // +1 to skip the comma
Console.WriteLine($"Substring after comma: {substring1}"); // Outputs: Substring after comma:  World!

//==================================================================================
//C# Special Characters
string txt = "We are the so-called \"Vikings\" from the north."; // output : We are the so-called "Vikings" from the north.
Console.WriteLine(txt);
string txt2 = "It\'s alright."; // output : It's alright.
Console.WriteLine(txt2);
string txt3 = "The character \\ is called backslash."; // output : The character \ is called backslash.
Console.WriteLine(txt3);
string txt4 = "Hello\nWorld!"; // output : Hello
//World! (new line)
Console.WriteLine(txt4);
string txt5 = "Hello\tWorld!"; // output : Hello   World! (tab space)
Console.WriteLine(txt5);
string txt6 = "Hello\rWorld!"; // output : HelloWorld! (carriage return)
Console.WriteLine(txt6);
string txt7 = "Hello\bWorld!"; // output : HelloWorld! (backspace)
Console.WriteLine(txt7);

//===========================================================================================
//C# If...Else
if(20 > 10)
{
    Console.WriteLine("20 is greater than 10");
}

//===========================================================================================

if (20 < 10)
{
    Console.WriteLine("20 is less than 10");
}
else
{
    Console.WriteLine("20 is not less than 10");
}

//===========================================================================================
if (20 < 10)
{
    Console.WriteLine("20 is less than 10");
}
else if (20 == 10)
{
    Console.WriteLine("20 is equal to 10");
}
else
{
    Console.WriteLine("20 is greater than 10");
}

//===========================================================================================
//ternary operator
string result1 = (20 > 10) ? "20 is greater than 10" : "20 is not greater than 10";
Console.WriteLine(result1);

//===========================================================================================
//C# Switch Statement
int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

//===========================================================================================
//C# While Loop
int i = 0;
while (i < 5)
{
    Console.WriteLine($"i: {i}");
    i++;
}

//===========================================================================================
//C# Do...While Loop
int j = 0;
do
{
    Console.WriteLine($"j: {j}");
    j++;
} while (j < 5);

//===========================================================================================
//C# For Loop
for (int k = 0; k < 5; k++)
{
    Console.WriteLine($"k: {k}");
}

//===========================================================================================
//C# Foreach Loop
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string car in cars)
{
    Console.WriteLine($"car: {car}");
}

//===========================================================================================
//C# Break and Continue
//C# Break Statement
for (int l = 0; l < 10; l++)
{
    if (l == 4)
    {
        break; // Exit the loop when l is 4
    }
    Console.WriteLine($"l: {l}");
}

//===========================================================================================
//C# Continue Statement
for (int m1 = 0; m1 < 10; m1++)
{
    if (m1 == 4)
    {
        continue; // Skip the rest of the loop when m1 is 4
    }
    Console.WriteLine($"m1: {m1}");
}

//===========================================================================================
//C# Arrays
// In C#, an array is a data structure that can hold a fixed number of values of a single type.
// The values in an array are called elements, and each element can be accessed by its index

string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
// Accessing array elements using their index
Console.WriteLine($"First car: {cars1[0]}");
Console.WriteLine($"Second car: {cars1[1]}");

//change an array element
cars1[0] = "Opel"; // Changing the first element of the array
Console.WriteLine($"Updated first car: {cars1[0]}");

//array length
Console.WriteLine($"Number of cars: {cars1.Length}");

//other way to declare an array
string[] cars2 = new string[4]; // Declaring an array of strings with 4 elements
Console.WriteLine($"Number of cars2: {cars2.Length}");
string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" }; // Declaring and initializing an array of strings with 4 elements
Console.WriteLine($"Number of cars3: {cars3.Length}");
string[] cars4 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" }; // Declaring and initializing an array of strings with 4 elements
Console.WriteLine($"Number of cars4: {cars4.Length}");

//===========================================================================================
//Loop through an array
string[] cars5 = { "Volvo", "BMW", "Ford", "Mazda" };
for (int n = 0; n < cars5.Length; n++)
{
    Console.WriteLine($"car: {cars5[n]}");
}

foreach (string car in cars5)
{
    Console.WriteLine($"car: {car}");
}

//sort an array
Array.Sort(cars5); // Sorts the array in ascending order
foreach (string car in cars5)
{
    Console.WriteLine($"Sorted car: {car}");
}

//min,max,sum 
int[] numbers = { 5, 10, 15, 20, 25 };
Console.WriteLine($"Min: {numbers.Min()}");
Console.WriteLine($"Max: {numbers.Max()}");
Console.WriteLine($"Sum: {numbers.Sum()}");

//===========================================================================================
//Multidimensional Arrays
// In C#, a multidimensional array is an array of arrays, where each element can be
// accessed using multiple indices. The most common type of multidimensional array is the two-dimensional array, which can be visualized as a table or matrix.
// Two-Dimensional Array

int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
//The single comma (,) in the declaration indicates that this is a two-dimensional array.
// Accessing elements in a two-dimensional array
Console.WriteLine($"Element at (0,0): {matrix[0, 0]}");
Console.WriteLine($"Element at (1,2): {matrix[1, 2]}");

// Looping through a two-dimensional array
for (int row = 0; row < matrix.GetLength(0); row++) // GetLength(0) returns the number of rows
{
    for (int col = 0; col < matrix.GetLength(1); col++) // GetLength(1) returns the number of columns
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine(); // New line after each row
}

//===========================================================================================
//C# methods
// In C#, a method is a block of code that performs a specific task.

static void GreetUser(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
//static - indicates that the method belongs to the class itself rather than to any specific instance of the class
//void - indicates that the method does not return any value
//GreetUser - is the name of the method
//(string name) - indicates that the method takes a single parameter of type string, which is used to pass information into the method

// Calling the method
GreetUser("Alice"); // Outputs: Hello, Alice!
