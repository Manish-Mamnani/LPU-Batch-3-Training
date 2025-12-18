// See https://aka.ms/new-console-template for more information
using System;
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number : ");
            // string? name = Console.ReadLine();
            // Console.WriteLine("Hello, "+name+"!");     
            bool check = int.TryParse(Console.ReadLine(),out int num);
            if(check)
            {
                Boolean b = true;
                for(int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        b = false;
                        Console.WriteLine(num+" is not a Prime Number!");
                        break;
                    }
                }
                if (b)
                {
                    Console.WriteLine(num+" is a Prime Number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }

