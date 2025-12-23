using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Laptop : Computer
    {
        #region Properties

        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        #endregion

        #region Methods

        public double LaptopPriceCalculation()
        {
            int processorCost = 0;
            switch (Processor)
            {
                case "i3":
                    {
                        processorCost = 2500;
                        break;
                    }
                case "i5":
                    {
                        processorCost = 5000;
                        break;
                    }
                case "i7":
                    {
                        processorCost = 6500;
                        break;
                    }
            }
            double laptopPrice = processorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (DisplaySize * 250) + (BatteryVolt * 20);
            return laptopPrice;
        }

        #endregion
    }
}
