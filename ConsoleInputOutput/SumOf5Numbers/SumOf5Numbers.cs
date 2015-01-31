/*Write a program that enters 5 numbers (given in a single line, separated by a space), 
 * calculates and prints their sum.*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class SumOf5Numbers
{
    static void Main()
    {
        //Split the numbers by space 
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        string[] numStr = input.Split(' ');
        double a = double.Parse(numStr[0]);
        double b = double.Parse(numStr[1]);
        double c = double.Parse(numStr[2]);
        double d = double.Parse(numStr[3]);
        double e = double.Parse(numStr[4]);
        Console.WriteLine(a + b + c + d + e);
    }
}

