using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeWorldDay5Assignment
{
    internal class Cake
    {
        #region Properties

        public string Flavor {  get; set; }
        public int QuantityInKg {  get; set; }
        public double PricePerKg {  get; set; }

        #endregion

        #region Methods

        public bool CakeOrder()
        {
            if (!(Flavor == "Vanilla" || Flavor == "Chocolate" || Flavor == "Red Velvet"))
            {
                throw new InvalidFlavorException("Flavour not available. Please select the available flavour");
            }
            if (QuantityInKg <= 0)
            {
                throw new Exception("Quantity must be greater than zero");
            }
            return true;

        }

        public double CalculatePrice()
        {
            double totalPrice = QuantityInKg * PricePerKg;
            double discount = 0;
            switch (Flavor)
            {
                case "Vanilla":
                    {
                        discount = 3;
                        break;
                    }
                case "Chocolate":
                    {
                        discount = 5;
                        break;
                    }
                case "Red Velvet":
                    {
                        discount = 10;
                        break;
                    }
            }
            double discountedPrice = totalPrice - (totalPrice * discount / 100);
            return discountedPrice;
        }

        #endregion
    }
}
