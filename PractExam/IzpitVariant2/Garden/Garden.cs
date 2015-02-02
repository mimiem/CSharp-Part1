using System;

class Garden
{
    static void Main()
    {
        double tomatoPrice = 0.5;
        double cucumberPrice = 0.4;
        double potatoPrice = 0.25;
        double carrotPrice = 0.6;
        double cabbagePrice = 0.3;
        double beansPrice = 0.4;
        int availableArea = 250;

        int tomatoAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberAmount = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoAmount = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageAmount = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansAmount = int.Parse(Console.ReadLine());

        double totalPrice = tomatoPrice * tomatoAmount + cucumberPrice * cucumberAmount + potatoPrice * potatoAmount + carrotPrice * carrotAmount + cabbagePrice * cabbageAmount + beansPrice * beansAmount;
        Console.WriteLine("Total costs: {0:F2}", totalPrice);
        int usedArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

        if (usedArea<availableArea)
        {
            int beansArea = availableArea - usedArea;
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (usedArea==availableArea)
        {
            Console.WriteLine("No area for beans");
        }
        else if (usedArea>availableArea)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

