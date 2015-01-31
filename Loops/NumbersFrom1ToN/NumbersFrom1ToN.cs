/*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.*/

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a integer: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.Write("{0} ", counter);
            counter++;
        }
    }
}

