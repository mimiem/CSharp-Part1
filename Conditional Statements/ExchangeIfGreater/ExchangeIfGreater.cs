/*Write an if-statement that takes two double variables a and b and exchanges 
 * their values if the first one is greater than the second one. As a result 
 * print the values a and b, separated by a space.*/

using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.Write(b + " " + a);
        }
        else
        {
            Console.Write(a + " " + b);
        }
        Console.WriteLine();
    }
}

