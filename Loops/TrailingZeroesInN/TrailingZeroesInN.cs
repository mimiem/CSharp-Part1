/*Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int trailingZeroes = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        while (factorial % 10 == 0)
        {
            trailingZeroes++;
            factorial /= 10;
        }
        Console.WriteLine("Trailing Zeroes: {0}", trailingZeroes);
    }
}

