using System;

class Eggcelent
{
    static void Main()
    {
        int n = 4; //int.Parse(Console.ReadLine());

        int height = 2 * n;
        int width = 3 * n + 1;
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((col > n && col < 2 * n) && (row == 0 || row == height - 1)) 
                {
                    Console.Write('*');
                }
                else if ((row >= n/2 && row < 2 * n - n/2) && (col == 1 || col == width - 2))
                {
                    Console.Write("*");
                }
                else if (2 * row - col == -(2 * n - 1) || 2 * row - col == 3 * n - 3)
                {
                    Console.Write("*");
                }
                else if (2 * row + col == n + 1 || 2 * row + col == 6 * n - 3)
                {
                    Console.Write("*");
                }
                else if ((row == n-1 || row == n) && (col > 1 && col < width - 2) && (row + col) % 2 == 1)
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
     // n = 4
     //
     //.....***.....
     //...*.....*...
     //.*.........*.
     //.*@.@.@.@.@*.
     //.*.@.@.@.@.*.
     //.*.........*.
     //...*.....*...
     //.....***.....

}

