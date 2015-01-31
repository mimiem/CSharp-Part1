//Write an expression that checks if given integer is odd or even.


using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0) 
        {    
            Console.WriteLine("The number {0} is even.", a);
        }
        else
        {   
            Console.WriteLine("The number {0} is odd", a);
        }        
    }
}

