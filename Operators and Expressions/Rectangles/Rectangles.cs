//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Globalization;
using System.Threading;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Width = ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Height = ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter = {0}", (2 * a) + (2 * b));
        Console.WriteLine("Area = {0}", a * b);
    }
}

