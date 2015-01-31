/*Write a program that reads the coefficients a, b and c of a quadratic 
 * equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double d = ((b * b) - (4 * a * c));    //diskriminant
        double x1 = ((-b - Math.Sqrt(d)) / (2 * a)); //formula for square roots
        double x2 = ((-b + Math.Sqrt(d)) / (2 * a));

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (x1 == x2)   //one root
        {
            Console.WriteLine("x1 = x2 = " + x1);
        }
        else                 // two roots
        {
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}

