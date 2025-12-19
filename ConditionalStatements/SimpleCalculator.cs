using System;

namespace ConditionalStatements;

public class SimpleCalculator
{
    public void SimpleMain()
    {
        Console.Write("Enter first number: ");
        bool check1 = double.TryParse(Console.ReadLine(),out double number1);
        Console.Write("Enter second number: ");
        bool check2 = double.TryParse(Console.ReadLine(),out double number2);

        if(!check1 || !check2)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        Console.Write("Enter an operator (+, -, *, /): ");
        string? op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Result: "+(number1 + number2));
                break;
            case "-":
                Console.WriteLine("Result: "+(number1 - number2));
                break;
            case "*":
                Console.WriteLine("Result: "+(number1 * number2));
                break;
            case "/":
                Console.WriteLine("Result: "+(number1 / number2));
                break;
            default:
                Console.WriteLine("Invalid Operator!");
                break;
        }
    }
}
