//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class CalculateProblem6
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        
        if (1 < k && k < n && n < 100)
        {
            int result = 1;
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("n!/k! = {0}", result);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

