//Write an expression that checks for given integer if its third digit from right-to-left is 7

using System;

class ThirdDigit7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int getNumber = (number / 100) % 10;
        bool is7Number = getNumber == 7;
        Console.WriteLine("Is the third digit 7? : {0}", is7Number);
     }
}

