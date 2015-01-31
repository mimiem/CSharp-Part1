﻿/*Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/

using System;

class RandomNumbersInGivenRenge
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine("Random numbers: ");
        
        if (min <= max)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", randomNumber.Next(min, max));
            }
        }
        else
        {
            Console.WriteLine("incorrect input");
        }
        Console.WriteLine();
    }
}

