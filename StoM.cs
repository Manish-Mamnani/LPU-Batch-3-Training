using System;

class Time
{
    static void Main()
    {
        Console.Write("Enter total seconds: ");
        string? input = Console.ReadLine();
        bool check = int.TryParse(input, out int seconds); 
        if (!check)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (seconds < 0)
        {
            Console.WriteLine("Seconds cannot be negative.");
            return;
        }

        int minutes = seconds / 60;
        int remainingSeconds = seconds % 60;

        Console.WriteLine($"{seconds} seconds = {minutes} minute(s) and {remainingSeconds} second(s)");
    }
}