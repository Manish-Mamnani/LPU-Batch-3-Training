using System;

namespace ConditionalStatements;

public class Quadratic
{
    public void QuadraticMain()
    {
        Console.Write("Enter a: ");
        bool checkA = double.TryParse(Console.ReadLine(), out double a);
        Console.Write("Enter b: ");
        bool checkB = double.TryParse(Console.ReadLine(), out double b);
        Console.Write("Enter c: ");
        bool checkC = double.TryParse(Console.ReadLine(), out double c);

        if(!checkA || !checkB || !checkC)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        double D = b*b - 4*a*c;

        if (D > 0)
        {
            double r1 = (-b + Math.Sqrt(D))/(2*a);
            double r2 = (-b - Math.Sqrt(D))/(2*a);
            System.Console.WriteLine("Roots are real: "+r1+", "+r2);
        }
        else if(D == 0)
        {
            double r = -b/(2*a);
            System.Console.WriteLine("Roots are equal: "+r);
        }
        else
        {
            System.Console.WriteLine("No real roots.");
        }
    }
}
