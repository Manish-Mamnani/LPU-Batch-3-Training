using System;

class Convert
{
    static void Main()
    {
        double CmPerFoot = 30.48;

        Console.Write("Enter feet: ");
        string? input = Console.ReadLine();
        bool check = double.TryParse(input, out double feet);
        if (!check)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        if (feet<0)
        {
            Console.WriteLine("Feet cannot be negative.");
            return;
        }

        double cm = feet * CmPerFoot;
        Console.WriteLine($"{feet} feet = {cm:F2} cm");
    }
}