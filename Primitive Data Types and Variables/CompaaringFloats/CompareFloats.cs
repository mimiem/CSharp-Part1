//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;
using System.Globalization;
using System.Threading;

class CompareFloats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool compareNumbers = (Math.Abs(firstNumber - secondNumber) < eps);
        Console.WriteLine(compareNumbers);
     }
}

