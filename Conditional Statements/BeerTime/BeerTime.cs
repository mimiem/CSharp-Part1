/*A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.*/

using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        Console.Write("Enter time in format like this for example -\"11:20 AM\": ");
        string date = Console.ReadLine();
        DateTime time = DateTime.Parse(date);
        time.ToString("hh:mm tt");
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        if (time >= startTime || time <= endTime)
        {
            Console.WriteLine("Beer time!");
        }
        else
        {
            Console.WriteLine("Non-beer time!");
        }
    }
}

