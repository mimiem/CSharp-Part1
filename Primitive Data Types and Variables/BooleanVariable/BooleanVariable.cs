//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

using System;

class BooleanVariable
{
    static void Main()
    {
        int male = 1;
        int female = 2;
        bool isFemale = (male < female);
        Console.WriteLine("My gender is Female: {0}", isFemale);
    }
}

