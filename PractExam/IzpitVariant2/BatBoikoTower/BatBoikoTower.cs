using System;

class BatBoikoTower
{
    static void Main()
    {
        int n = 5; //int.Parse(Console.ReadLine());

        int update = 2;
        int rowToHaveDash = 2;

        for (int i = 1; i <= n; i++)
        {
            var middleCharacter = '.';
            if (i == rowToHaveDash)
            {
                middleCharacter = '-';
                rowToHaveDash += update;
                ++update;
            }
            
               Console.Write(new string('.', n - i)); 
               Console.Write("/"); 
               Console.Write(new string(middleCharacter, 2 * i - 2));
               Console.Write("\\");
               Console.Write(new string('.', n - i));
               Console.WriteLine();
        }
    }
}
// n = 5
// ..../\....
// .../--\...
// ../....\..
// ./------\.
// /........\

//   n = 11
/*  ........../\..........
    ........./--\.........
    ......../....\........
    ......./------\.......
    ....../........\......
    ...../..........\.....
    ..../------------\....
    .../..............\...
    ../................\..
    ./..................\.
    /--------------------\
*/
