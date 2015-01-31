/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).*/

using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        //Check your console font -  you may need to change it to Consolas!!!
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}: {1}", i, symbol);
        }
    }
}

