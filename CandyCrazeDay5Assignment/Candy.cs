using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrazeDay5Assignment
{
    internal class Candy
    {
        #region Properties

        public string Flavor { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double Discount {  get; set; }

        #endregion

        #region Methods

        public bool ValidateCandyFlavor()
        {
            if(Flavor == "Strawberry" || Flavor == "Lemon" || Flavor == "Mint")
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
