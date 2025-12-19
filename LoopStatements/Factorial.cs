using System;

namespace LoopStatements;

public class Factorial
{
    public void FactorialMain()
    {
        Console.Write("Enter a non-negative integer: ");
        bool check = int.TryParse(Console.ReadLine(), out int number);

        if(!check || number < 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            if (factorial > long.MaxValue / i)
            {
                Console.WriteLine("Error: Overflow will occur!");
                return;
            }
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {number} is {factorial}");
    }
}
