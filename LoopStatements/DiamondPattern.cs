using System;

namespace LoopStatements;

public class DiamondPattern
{
    public void DiamondMain()
    {
        Console.Write("Enter number of rows (odd number): ");
        bool check = int.TryParse(Console.ReadLine(), out int rows);

        if(!check || rows <= 0 || rows % 2 == 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int n = rows / 2 + 1;

        
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        
        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
