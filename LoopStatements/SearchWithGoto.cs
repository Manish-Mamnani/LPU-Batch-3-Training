using System;

namespace LoopStatements;

public class SearchWithGoto
{
    public void SearchMain()
    {
        Console.Write("Enter the number of elements: ");
        bool check = int.TryParse(Console.ReadLine(), out int n);

        if(!check || n <= 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements:");
        for(int i = 0; i < n; i++)
        {
            bool elementCheck = int.TryParse(Console.ReadLine(), out arr[i]);
            if(!elementCheck)
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
        }

        Console.Write("Enter the element to search: ");
        bool searchCheck = int.TryParse(Console.ReadLine(), out int searchElement);
        if(!searchCheck)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        bool found = false;
        for(int i = 0; i < n; i++)
        {
            if(arr[i] == searchElement)
            {
                found = true;
                goto Found;
            }
        }

    Found:
        if(found)
        {
            Console.WriteLine($"{searchElement} is found in the array.");
        }
        else
        {
            Console.WriteLine($"{searchElement} is not found in the array.");
        }
    }
}
