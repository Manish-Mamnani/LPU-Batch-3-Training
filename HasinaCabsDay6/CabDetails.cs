using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasinaCabsDay6
{
    internal class CabDetails : Cab
    {
        #region Methods

        public bool ValidateBookingID()
        {
            if (BookingID.Length == 6 && BookingID.StartsWith("AC") && BookingID[2] == '@' && BookingID.Substring(3).All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public double CalculateFareAmount()
        {
            double pricePerKm = 0;
            switch (CabType)
            {
                case "Hatchback":
                    {
                        pricePerKm = 10;
                        break;
                    }
                case "Sedan":
                    {
                        pricePerKm = 20;
                        break;
                    }
                case "SUV":
                    {
                        pricePerKm = 30;
                        break;
                    }
            }
            double waitingCharge = Math.Sqrt(WaitingTime);
            double fare = (Distance * pricePerKm) + waitingCharge;
            return Math.Round(fare,2);
        }

        #endregion
    }
}
