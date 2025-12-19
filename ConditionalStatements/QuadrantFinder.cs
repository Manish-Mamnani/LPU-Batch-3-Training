using System;

namespace ConditionalStatements;

public class QuadrantFinder
{
    public void QuadrantMain()
    {
        Console.Write("Enter X coordinate: ");
        bool check1 = double.TryParse(Console.ReadLine(), out double x);
        Console.Write("Enter Y coordinate: ");
        bool check2 = double.TryParse(Console.ReadLine(), out double y);

        if (!check1 || !check2)
        {
            System.Console.WriteLine("Invalid Input!");
            return;
        }

        if (x > 0 && y > 0)
        {
            System.Console.WriteLine("Point lies in First Quadrant");
        }
        else if (x < 0 && y > 0)
        {
            System.Console.WriteLine("Point lies in Second Quadrant");
        }
        else if (x < 0 && y < 0)
        {
            System.Console.WriteLine("Point lies in Third Quadrant");
        }
        else if (x > 0 && y < 0)
        {
            System.Console.WriteLine("Point lies in Fourth Quadrant");
        }
        else
        {
            System.Console.WriteLine("Point lies on an axis");
        }
    }
}
