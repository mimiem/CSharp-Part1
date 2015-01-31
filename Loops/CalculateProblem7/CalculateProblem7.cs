/*In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/

using System;

class CalculateProblem7
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            int result1 = 1;
            int result2 = 1;
            int count = 1;

            for (int i = n - k + 1; i <= n; i++)
            {
                result1 *= i;
                if (count <= k)
                {
                    result2 *= count;
                    count++;
                }
            }
            Console.WriteLine(result1 / result2);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

