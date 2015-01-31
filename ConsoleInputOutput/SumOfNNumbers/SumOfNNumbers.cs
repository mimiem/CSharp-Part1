/*Write a program that enters a number n and after that enters more n numbers 
 * and calculates and prints their sum.*/

using System;
using System.Globalization;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        decimal sum = 0.00m;
        decimal number = decimal.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = decimal.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}

