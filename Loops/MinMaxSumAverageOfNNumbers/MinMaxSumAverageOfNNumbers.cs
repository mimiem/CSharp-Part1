/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > max)
            {
                max = input;
            }
            if (input < min)
            {
                min = input;
            }
            sum += input;
        }
        avg = sum / n;
        Console.WriteLine("Min is {0}", min);
        Console.WriteLine("Max is {0}", max);
        Console.WriteLine("Sum is {0}", sum);
        Console.WriteLine("Avg is {0:F2}", avg);
    }
}

