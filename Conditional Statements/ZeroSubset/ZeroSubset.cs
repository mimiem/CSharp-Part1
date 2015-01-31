/*We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.*/

using System;

class ZeroSubset
{
    static void Main()    // Mnogo dyrven variant, ama za skromnite vyzmojnosti, tolkova. Sorry!
    {
        Console.WriteLine("Please enter five integer numbers");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());
        string sum2Numbers = "{0} + {1} = 0";
        string sum3Numbers = "{0} + {1} + {2} = 0";
        string sum4Numbers = "{0} + {1} + {2} + {3} = 0";

        if (a + b == 0)
        {
            Console.WriteLine(sum2Numbers, a, b);
        }
        if (a + c == 0)
        {
            Console.WriteLine(sum2Numbers, a, c);
        }
        if (a + d == 0)
        {
            Console.WriteLine(sum2Numbers, a, d);
        }
        if (a + e == 0)
        {
            Console.WriteLine(sum2Numbers, a, e);
        }
        if (b + c == 0)
        {
            Console.WriteLine(sum2Numbers, b, c);
        }
        if (b + d == 0)
        {
            Console.WriteLine(sum2Numbers, b, d);
        }
        if (b + e == 0)
        {
            Console.WriteLine(sum2Numbers, b, e);
        }
        if (c + d == 0)
        {
            Console.WriteLine(sum2Numbers, c, d);
        }
        if (c + e == 0)
        {
            Console.WriteLine(sum2Numbers, c, e);
        }
        if (d + e == 0)
        {
            Console.WriteLine(sum2Numbers, d, e);
        }
        if (a + b + c == 0)
        {
            Console.WriteLine(sum3Numbers, a, b, c);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine(sum3Numbers, a, b, d);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine(sum3Numbers, a, b, e);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine(sum3Numbers, a, c, d);
        }
        if (a + c + e == 0)
        {
            Console.WriteLine(sum3Numbers, a, c, e);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine(sum3Numbers, a, d, e);
        }
        
        if (b + c + d == 0)
        {
            Console.WriteLine(sum3Numbers, b, c, d);
        }
        if (b + c + e == 0)
        {
            Console.WriteLine(sum3Numbers, b, c, e);
        }
        if (b + d + e == 0)
        {
            Console.WriteLine(sum3Numbers, b, d, e);
        }
        if (c + d + e == 0)
        {
            Console.WriteLine(sum3Numbers, c, d, e);
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine(sum4Numbers, a, b, c, d);
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine(sum4Numbers, a, b, c, e);
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine(sum4Numbers, a, b, d, e);
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine(sum4Numbers, a, c, d, e);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine(sum4Numbers, b, c, d, e);
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        else
        {
            Console.WriteLine("no zero subset");
        }
    }
}

