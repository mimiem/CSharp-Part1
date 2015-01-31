/*Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The number can be devided by 5 and 7:");
        Console.WriteLine(n % 5 == 0 && n % 7 == 0);
    }
}

