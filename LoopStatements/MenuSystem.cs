using System;

namespace LoopStatements;

public class MenuSystem
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Reverse a Number and Check Palindrome");
            Console.WriteLine("2. Generate Fibonacci Series");
            Console.WriteLine("3. Calculate Sum of Digits");
            Console.WriteLine("4. Demonstrate Continue Statement");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReverseAndPalindrome reverseAndPalindrome = new ReverseAndPalindrome();
                    reverseAndPalindrome.ReverseMain();
                    break;
                case "2":
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.FibonacciMain();
                    break;
                case "3":
                    SumOfDigits sumOfDigits = new SumOfDigits();
                    sumOfDigits.SumMain();
                    break;
                case "4":
                    ContinueUsage continueUsage = new ContinueUsage();
                    continueUsage.ContinueMain();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}
