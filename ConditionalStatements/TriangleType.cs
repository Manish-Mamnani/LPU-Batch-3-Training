using System;

namespace ConditionalStatements;

public class Triangle
{
    public void TriangleMain()
    {
        Console.Write("Enter side1: ");
        bool check1 = int.TryParse(Console.ReadLine(), out int a);
        Console.Write("Enter side2: ");
        bool check2 = int.TryParse(Console.ReadLine(), out int b);
        Console.Write("Enter side3: ");
        bool check3 = int.TryParse(Console.ReadLine(), out int c);

        if (!check1 || !check2 || !check3)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        if (a == b && b == c)
        {
            Console.WriteLine("Equilateral Triangle");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("Isosceles Triangle");
        }
        else
        {
            Console.WriteLine("Scalene Triangle");
        }
    }
}
