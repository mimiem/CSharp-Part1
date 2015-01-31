/*Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime birthDay = new DateTime(1989, 12, 16);
        DateTime todaysDate = DateTime.Now;
        var MyAge = todaysDate.Year - birthDay.Year;
        Console.WriteLine("My Age is: " + MyAge);
        var myFutureAge = MyAge + 10;
        Console.WriteLine("My Age in 10 years will be: " + myFutureAge);
    }
}

