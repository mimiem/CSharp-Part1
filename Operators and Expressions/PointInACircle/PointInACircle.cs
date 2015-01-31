//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double c = 2;
        bool point = ((x * x) + (y * y)) <= (c * c);
        Console.WriteLine(point);
    }
}

