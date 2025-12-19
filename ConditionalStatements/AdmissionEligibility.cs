using System;

namespace ConditionalStatements;

public class Admission
{
    public void AdmissionMain()
    {
        Console.Write("Math Marks: ");
        bool checkA = int.TryParse(Console.ReadLine(), out int math);
        Console.Write("Physics Marks: ");
        bool checkB = int.TryParse(Console.ReadLine(), out int physics);
        Console.Write("Chemistry Marks: ");
        bool checkC = int.TryParse(Console.ReadLine(), out int chemistry);

        if(!checkA || !checkB || !checkC)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int totalMarks = math + physics + chemistry;

        if(math>=65 && physics>=55 && chemistry >= 50)
        {
            if(totalMarks>=180 || (math + physics) >= 140)
            {
                System.Console.WriteLine("Eligible for Admission.");
            }
            else
            {
                System.Console.WriteLine("Not Eligible.");
            }
        }
        else
        {
            System.Console.WriteLine("Not Eligible.");
        }

    }
}
