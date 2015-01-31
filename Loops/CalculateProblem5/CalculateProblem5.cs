﻿/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;

class CalculateProblem5
{
    static void Main()
    {
        Console.Write("n = "); 
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double factoriel = 1;
        double power = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            power *= x;
            sum += factoriel / power;
        }
        Console.WriteLine("S = {0:F5}", sum);
    }
}

