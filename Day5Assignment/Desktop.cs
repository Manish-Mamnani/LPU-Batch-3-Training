using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Desktop : Computer
    {
        #region Properties

        public int MonitorSize { get; set; }
        public int PowerSupplyVolt {  get; set; }

        #endregion

        #region Methods

        public double DesktopPriceCalculation()
        {
            int processorCost = 0;
            switch (Processor)
            {
                case "i3":
                    {
                        processorCost = 1500;
                        break;
                    }
                case "i5":
                    {
                        processorCost = 3000;
                        break;
                    }
                case "i7":
                    {
                        processorCost = 4500;
                        break;
                    }
            }
            double desktopPrice = processorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (MonitorSize * 250) + (PowerSupplyVolt * 20);
            return desktopPrice;

        }

        #endregion
    }
}
