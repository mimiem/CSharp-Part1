//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? number = null;
        double? anotherNumber = null;
        Console.WriteLine("Number is: {0}", number);
        Console.WriteLine("Another number is: {0}", anotherNumber);
        number = 2925;
        anotherNumber = 2917;
        Console.WriteLine("Number is: {0}", number);
        Console.WriteLine("Another number is: {0}", anotherNumber);
    }
}

