using System;

namespace LoopStatements;

public class PascalTriangle
{
    public void PascalMain()
    {
        Console.Write("Enter number of rows: ");
        bool check = int.TryParse(Console.ReadLine(), out int rows);

        if(!check || rows <= 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        for (int i = 0; i < rows; i++)
        {
            int number = 1;
            Console.Write(new string(' ', (rows - i) * 2));

            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{number,4}");
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
