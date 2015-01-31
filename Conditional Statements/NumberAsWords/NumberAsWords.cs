//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Please enter a number between 0 and 999: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.Write("The number is: ");
        
        string[] zeroToNine = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tenToNineteen = new string[10] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] zeroTenths = new string[10] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] zeroToNineCapital = new string[10] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] tenToNineteenCapital = new string[10] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] zeroTenthsCapital = new string[10] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        
        if (number < 10)
        {
            Console.WriteLine(zeroToNineCapital[number]); // 1, 2, 3...9
        }
        else if (number > 9 && number < 20) 
        {
            Console.WriteLine(tenToNineteenCapital[number % 10]); // 11, 12, 13...19
        }
        else if (number > 19 && number < 100)
        {
            if (number % 10 == 0)   
            {
                Console.WriteLine(zeroTenthsCapital[number / 10]);   // 10, 20, 30...90
            }
            else 
            {
                Console.WriteLine(zeroTenthsCapital[number / 10] + " " + zeroToNine[number%10]); // 21, 22...31...99
            }
        }
        else if (number > 100 && number < 1000)
        {
            if (number % 100 == 0)
            {
                Console.WriteLine(zeroToNineCapital[number / 100] + " hundred"); // 100, 200...900
            }
            else if (number - ((number / 100) * 100) > 9 && number - ((number / 100) * 100) < 20) 
            {
                Console.WriteLine(zeroToNineCapital[number / 100] + " hundred and " + tenToNineteen[number % 10]); // 111, 112...211,212...919
            }
            else if (number - ((number / 100) * 100) < 10)
            {
                Console.WriteLine(zeroToNineCapital[number/100] + " hundred and "+ zeroToNine[number % 10]); // 101, 102...109; 201...209;...909
            }
            else if ((number - ((number / 100) * 100)) % 10 == 0)
            {
                Console.WriteLine(zeroToNineCapital[number / 100] + " hundred and " + zeroTenths[(number / 10) % 10]); // 110, 120...990
            }
            else
            {
                Console.WriteLine(zeroToNineCapital[number / 100] + " hundred and " + zeroTenths[(number / 10) % 10] + " " + zeroToNine[number % 10]); // all others
            }
        }
    }
}

