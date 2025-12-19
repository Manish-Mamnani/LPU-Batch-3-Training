using System;
namespace ConditionalStatements;

public class Height{
    public void HeightMain()
    {
        Console.Write("Enter your height in cm: ");

        bool check = int.TryParse(Console.ReadLine(), out int height);
        if (!check)
        {
            System.Console.WriteLine("Invalid Input! Enter a whole number.");
            return;
        }

        if (height < 150)
        {
            System.Console.WriteLine("You are dwarf.");            
        }
        else if(height >= 150 && height < 165)
        {
            System.Console.WriteLine("You are of average height.");
        }
        else if(height >= 165 && height < 190)
        {
            System.Console.WriteLine("You are tall.");
        }
        else
        {
            System.Console.WriteLine("You are of abnormal height.");
        }
    }
}