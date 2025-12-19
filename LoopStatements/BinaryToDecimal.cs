using System;

namespace LoopStatements;

public class BinaryToDecimal
{
    public void BinaryMain()
    {
        Console.Write("Enter a binary number: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || !IsBinary(input))
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int decimalValue = 0;
        int length = input.Length;

        for (int i = 0; i < length; i++)
        {
            if (input[length - 1 - i] == '1')
            {
                decimalValue += (1 << i); // 2^i
            }
        }

        Console.WriteLine($"Decimal value: {decimalValue}");
    }

    private bool IsBinary(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1')
            {
                return false;
            }
        }
        return true;
    }
}   
