using System;

namespace ConditionalStatements;

public class GradeDescription
{
    public void GradeMain()
    {
        Console.Write("Enter your grade (E,V,G,A,F): ");
        char grade = char.ToUpper(Console.ReadLine()[0]);

        switch (grade)
        {
            case 'E':
                Console.WriteLine("Excellent");
                break;
            case 'V':
                Console.WriteLine("Very Good");
                break;
            case 'G':
                Console.WriteLine("Good");
                break;
            case 'A':
                Console.WriteLine("Average");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid Grade");
                break;
        }
    }
}
