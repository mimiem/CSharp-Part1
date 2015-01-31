//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfFiveNumbers
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
        Console.Write("Enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());
        if ((a > b) && (a > c) && (a > d) && (a > e))
        {
            Console.WriteLine(a);
        }
        else if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            Console.WriteLine(b);
        }
        else if ((c > a) && (c > b) && (c > d) && (c > e))
        {
            Console.WriteLine(c);
        }
        else if ((d > a) && (d > b) && (d > c) && (d > e))
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}

