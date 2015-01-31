/*n combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("n = ");
        int n = int.Parse(Console.ReadLine());
        if (1 < n && n < 100)
        {
            BigInteger numerator = 1;
            BigInteger denominator = 1;
            BigInteger result = 1;
            for (int k = 2; k <= n; k++)
            {
                numerator *= n + k;
                denominator *= k;
            }
            result = numerator / denominator;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }      
    }
}

