using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasinaCabsDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CabDetails detailsObj = new CabDetails();

            Console.WriteLine("Enter booking ID");
            detailsObj.BookingID = Console.ReadLine();

            if (!detailsObj.ValidateBookingID())
            {
                Console.WriteLine("Invalid Booking ID");
                return;
            }

            Console.WriteLine("Enter cab type");
            detailsObj.CabType = Console.ReadLine();

            Console.WriteLine("Enter Distance");
            detailsObj.Distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter waiting time");
            detailsObj.WaitingTime = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The Fare amount is "+detailsObj.CalculateFareAmount());
        }
    }
}
