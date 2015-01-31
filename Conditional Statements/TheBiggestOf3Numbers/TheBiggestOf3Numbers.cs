//Write a program that finds the biggest of three numbers.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        if ((a > b) && (a > c))
        {
            Console.WriteLine(a);
        }
        else if ((b > a) && (b > c))
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

