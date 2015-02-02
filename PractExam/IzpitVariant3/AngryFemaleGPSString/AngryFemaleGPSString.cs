using System;

class AngryFemaleGPSString
{
    static void Main()
    {
        string num = Console.ReadLine();
        int sumOdd = 0;
        int sumEven = 0;


        for (int i = 0; i < num.Length; i++)
        {
            if (!Char.IsDigit(num[i]))
            {
                continue;
            }

            int digit = num[1] - '0';
            if (digit % 2 == 0)
            {
                sumEven += digit;
            }
            else
            {
                sumOdd += digit;
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("straight {0}", sumEven);
        }
        else if (sumOdd > sumEven)
        {
            Console.WriteLine("left {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("right {0}", sumEven);
        }
    }
}

