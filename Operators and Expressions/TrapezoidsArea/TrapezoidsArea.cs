//Write an expression that calculates trapezoid's area by given sides a and b and height h

using System;
using System.Globalization;
using System.Threading;

class TrapezoidsArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a =  ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b =  ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h =  ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid's area is: {0}", ((a + b)/2) * h);
    }
}

