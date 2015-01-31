/*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;
using System.Globalization;
using System.Threading;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double h = 1;
        double k = 1;
        double r = 1.5;
        if (((x - h) * (x - h) + (y - k) * (y - k)) <= (r * r))
        {
            Console.WriteLine("It's in the circle");
        }
        else
        {
            Console.WriteLine("It's outside of the circle");
        }
        if ((x > 5) || (x < -1) || (y > 1) || (y < -1))
        {
            Console.WriteLine("It's outside of the rectangle");
        }
        else
        {
            Console.WriteLine("It's in the rectangle");
        }
    }
}

