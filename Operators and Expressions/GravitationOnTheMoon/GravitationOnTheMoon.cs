﻿//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Globalization;
using System.Threading;

class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter weight:");
        decimal weight = decimal.Parse(Console.ReadLine());
        decimal weightOnTheMoon = weight * 0.17m ;
        Console.WriteLine("The weight on the Moon will be: {0}", weightOnTheMoon);
    }
}

