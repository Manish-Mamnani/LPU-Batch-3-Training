using System;

namespace ConditionalStatements;

public class Electricity
{
    public void ElectricityMain()
    {
        Console.Write("Enter units: ");

        bool check = double.TryParse(Console.ReadLine(), out double units);
        if (!check)
        {
            System.Console.WriteLine("Invalid Input!");
            return;
        }

        double amount = 0;

        if (units <= 199)
        {
            amount = units * 1.20;
        }
        else if(units <= 400)
        {
            amount = units * 1.50;
        }
        else if(units <= 600)
        {
            amount = units * 1.80;
        }
        else
        {
            amount = units * 2.00;
        }

        if(amount > 400)
        {
            amount += amount * 0.15;
        }

        System.Console.WriteLine("Total Bill = "+amount);
    }
}
