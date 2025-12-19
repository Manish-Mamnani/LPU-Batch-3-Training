using System;

namespace LoopStatements;

public class SumOfDigits
{
    public void SumMain()
    {
        Console.Write("Enter a number: ");
        bool check = int.TryParse(Console.ReadLine(), out int number);

        if(!check || number < 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int sum = 0;
        int temp = number;

        while(temp > 0)
        {
            int r = temp % 10;
            sum += r;
            temp /= 10;
        }

        Console.WriteLine($"Sum of digits of {number} is: {sum}");
    }
}
