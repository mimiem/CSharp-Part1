//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("The bit is: {0}", bit);
    }
}

