/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type");
        Console.WriteLine("1,2 or 3: ");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
                break;
            case 2:
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Console.Write("Please enter a double:");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string someText = Console.ReadLine();
                Console.WriteLine(someText + "*");
                break;
            default: 
                Console.WriteLine("It`s not correct choise"); 
            break;
        }
    }
}

