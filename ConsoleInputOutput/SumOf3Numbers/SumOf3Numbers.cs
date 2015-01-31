//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class SumOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum is: {0}", a + b + c); 
    }
}

