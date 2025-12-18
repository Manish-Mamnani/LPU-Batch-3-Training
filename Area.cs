using System;
    class Area
    {
        static void Main()
        {
            Console.Write("Enter radius of the circle : ");
            bool check = double.TryParse(Console.ReadLine(), out double radius);
            if (check)
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine("Area : "+area);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }

    }
