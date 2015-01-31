/*Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).*/

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int num = int.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                k++;
            }
        }
        if (k == 2)
        {
            Console.WriteLine("The number is prime", num);
        }
        else
        {
            Console.WriteLine("Not a prime number");
        }
    }
}

