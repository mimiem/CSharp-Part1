using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of bit:");
        int v = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The new number is: {0}", result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("The number stays the same: {0}", result);
        }
    }
}

