using System;

namespace ConditionalStatements;

public class ValidDateCheck
{
    public void DateMain()
    {
        Console.Write("Enter day: ");
        bool checkD = int.TryParse(Console.ReadLine(), out int day);
        Console.Write("Enter month: ");
        bool checkM = int.TryParse(Console.ReadLine(), out int month);
        Console.Write("Enter year: ");
        bool checkY = int.TryParse(Console.ReadLine(), out int year);

        if (!checkD || !checkM || !checkY)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        bool leapYear = (year%4==0) || (year%100!=0 && year%4==0);
        int[] days = {31, leapYear?29:28,31,30,31,30,31,31,30,31,30,31};

        if(month < 1 || month > 12)
        {
            System.Console.WriteLine("Invalid Date.");
            return;
        }
        if(day <1 || day > days[month - 1])
        {
            System.Console.WriteLine("Invalid Date.");
            return;
        }
        System.Console.WriteLine("Valid Date.");

        
    }
}
