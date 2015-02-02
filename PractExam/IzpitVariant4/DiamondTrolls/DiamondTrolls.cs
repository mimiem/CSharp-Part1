using System;

class DiamondTrolls
{
    static void Main()
    {
        int n = 7; //int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = 6 + (n - 3) / 2 * 3;

        int topDots = (width - n) / 2;
        Console.Write(new string('.', topDots));
        Console.Write(new string('*', n));
        Console.WriteLine(new string('.', topDots));

        int nextDots = topDots - 1;
        int topRows = topDots;

        for (int i = 0; i < topRows - 1; i++)
        {
            topDots--;
            Console.Write(new string('.', topDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.WriteLine(new string('.', topDots));
            nextDots++;
        }
        Console.WriteLine(new string('*', width));

        int firstDots = 1;

        for (int i = 0; i < n-1; i++)
        {
            nextDots--;
            Console.Write(new string('.', firstDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.WriteLine(new string('.', firstDots));

            firstDots++;

        }
        
        Console.Write(new string('.', n));
        Console.Write('*');
        Console.Write(new string('.', n));
        Console.WriteLine();
    }
}


 //n = 5
 //...*****...
 //..*..*..*..    
 //.*...*...*.
 //***********
 //.*...*...*.
 //..*..*..*..
 //...*.*.*...
 //....***....
 //.....*.....
 //
 
 