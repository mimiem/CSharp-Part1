using System;
using System.Globalization;
using System.Threading;

class CoffeeVendingMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double inMashine = n1 * 0.05 + n2 * 0.10 + n3 * 0.20 + n4 * 0.50 + n5;
        if (a>=p)
        {
            double change = a - p;
            if (change <= inMashine)
            {
                Console.WriteLine("Yes {0:F2}", inMashine - change);
            }
            else
            {
                Console.WriteLine("No {0:F2}", change - inMashine);
            }
        }
        else
        {
            Console.WriteLine("More {0:F2}", p-a);
        }
    }
}

