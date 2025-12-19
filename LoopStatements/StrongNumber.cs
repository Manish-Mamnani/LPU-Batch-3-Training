using System;

namespace LoopStatements;

public class StrongNumber
{
    public void StrongMain()
    {
        Console.Write("Enter a number: ");
        bool check = int.TryParse(Console.ReadLine(), out int number);

        if(!check || number < 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int temp = number;
        int sum = 0;

        while(temp > 0)
        {
            int r = temp % 10;
            int fact = 1;

            for(int i = 1; i <= r; i++)
            {
                fact *= i;
            }

            sum += fact;
            temp /= 10;
        }

        if(sum == number)
        {
            Console.WriteLine($"{number} is a Strong Number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Strong Number.");
        }
    }
}
