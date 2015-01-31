//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is {0}", Math.Max(firstNumber, secondNumber));
    }
}

