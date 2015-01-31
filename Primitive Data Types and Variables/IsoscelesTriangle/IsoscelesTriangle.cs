//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    //Check your console font -  you may need to change it to Consolas!!!
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copyright = '\u00A9';
        Console.WriteLine("    {0}", copyright);
        Console.WriteLine("   {0} {0}", copyright);
        Console.WriteLine("  {0}   {0}", copyright);
        Console.WriteLine(" {0} {0} {0} {0}", copyright);
    }
}

