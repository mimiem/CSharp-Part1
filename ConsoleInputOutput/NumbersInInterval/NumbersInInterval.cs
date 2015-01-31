/*Write a program that reads two positive integer numbers and 
 * prints how many numbers p exist between them such that the 
 * reminder of the division by 5 is 0.*/

using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter the start number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the end number: ");
        int endNumber = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                Console.Write(i + ", ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("p = " + p);
    }
}

