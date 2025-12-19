using System;

namespace ConditionalStatements;

public class VowelOrConsonant
{
    public void VowelMain()
    {
        Console.Write("Enter a character: ");
        char ch = char.ToLower(Console.ReadLine()[0]);
        switch(ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                System.Console.WriteLine("Vowel");
                break;
            
            default:
                System.Console.WriteLine("Consonant");
                break;
        }
    }
}
