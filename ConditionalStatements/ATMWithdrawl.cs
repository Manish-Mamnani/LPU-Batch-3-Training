using System;

namespace ConditionalStatements;

public class ATMWithdrawl
{
    public void ATM()
    {
        bool cardInserted = true;
        bool pinCorrect = true;
        double balance = 10000.00;

        Console.Write("Enter amount to withdraw: ");
        bool check = double.TryParse(Console.ReadLine(),out double withdrawlAmount);

        if (!check)
        {
            System.Console.WriteLine("Invalid Input! Enter a valid amount.");
            return;
        }

        if (cardInserted)
        {
            if (pinCorrect)
            {
                if(withdrawlAmount <= balance)
                {
                    System.Console.WriteLine("Withdrawl Successful!");
                }
                else
                {
                    System.Console.WriteLine("Indufficient Balance!");
                }
            }
            else
            {
                System.Console.WriteLine("Incorrect PIN! Retry.");
            }
        }
        else
        {
            System.Console.WriteLine("Please insert your ATM Card.");
        }
    }
}
