using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeWorldDay5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cake cakeObj = new Cake();

            Console.WriteLine("Enter the flavor:");
            cakeObj.Flavor = Console.ReadLine();

            Console.WriteLine("Enter the quantity in kg:");
            cakeObj.QuantityInKg = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per kg:");
            cakeObj.PricePerKg = Int32.Parse(Console.ReadLine());


            try
            {
                if (cakeObj.CakeOrder())
                {
                    Console.WriteLine("Cake order was successful!");
                    Console.WriteLine("Price after discount is: " + cakeObj.CalculatePrice());
                }
            }
            catch(Exception e)
            {
                    Console.WriteLine(e.Message);
            }
        }
    }
}
