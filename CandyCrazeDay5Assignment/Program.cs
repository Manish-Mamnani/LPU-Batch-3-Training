using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrazeDay5Assignment
{
    internal class Program
    {
        public static Candy CalculateDiscountedPrice(Candy candy)
        {
            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
            double discounted = 0;
            switch (candy.Flavor)
            {
                case "Strawberry":
                    {
                        discounted = 15;
                        break;
                    }
                case "Lemon":
                    {
                        discounted = 10;
                        break;
                    }
                case "Mint":
                    {
                        discounted = 5;
                        break;
                    }
            }
            candy.Discount = candy.TotalPrice - (candy.TotalPrice * discounted / 100);
            return candy;
        }
        static void Main(string[] args)
        {
            Candy candyObj = new Candy();

            Console.WriteLine("Enter the flavor:");
            candyObj.Flavor = Console.ReadLine();

            Console.WriteLine("Enter the quantity:");
            candyObj.Quantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per piece:");
            candyObj.PricePerPiece = Int32.Parse(Console.ReadLine());

            if (!candyObj.ValidateCandyFlavor())
            {
                Console.WriteLine("Invalid Flavor!");
                return;
            }

            CalculateDiscountedPrice(candyObj);

            Console.WriteLine("Flavor: "+candyObj.Flavor);
            Console.WriteLine("Quantity: "+candyObj.Quantity);
            Console.WriteLine("Price Per Piece: "+candyObj.PricePerPiece);
            Console.WriteLine("Total Price: "+candyObj.TotalPrice);
            Console.WriteLine("Discounted Price: "+candyObj.Discount);
        }
    }
}
