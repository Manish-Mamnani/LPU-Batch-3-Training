using System;

namespace ConditionalStatements;

public class ProfitOrLoss
{
    public void ProfitMain()
    {
        System.Console.Write("Enter Cost Price: ");
        bool check1 = double.TryParse(Console.ReadLine(), out double costPrice);
        System.Console.Write("Enter Selling Price: ");
        bool check2 = double.TryParse(Console.ReadLine(), out double sellingPrice);

        if(!check1 || !check2)
        {
            System.Console.WriteLine("Invalid Input!");
            return;
        }

        if(sellingPrice > costPrice)
        {
            System.Console.WriteLine("Profit of "+(sellingPrice - costPrice));
        }
        else if(costPrice > sellingPrice)
        {
            System.Console.WriteLine("Loss of "+(costPrice - sellingPrice));
        }
        else
        {
            System.Console.WriteLine("No Profit No Loss");
        }
    }
}
