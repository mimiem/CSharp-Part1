//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstText = "The \"use\" of quatations causes difficulties.";
        string secondText = @"The ""use"" of quatations causes difficulties";
        Console.WriteLine(firstText);
        Console.WriteLine(secondText);
    }
}

