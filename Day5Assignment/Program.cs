using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Desktop desktopObj = null;
            Laptop laptopObj = null;

            Console.WriteLine("----Device Info Menu----");
            Console.WriteLine("1. Desktop\n2. Laptop");
            Console.Write("Enter Your Choice: ");
            int deviceChoice = Int32.Parse(Console.ReadLine());

            switch (deviceChoice)
            {
                case 1:
                    {
                        desktopObj = new Desktop();

                        Console.WriteLine("Enter Processor Name:");
                        desktopObj.Processor = Console.ReadLine();

                        Console.WriteLine("Enter Ram Size (in GB):");
                        desktopObj.RamSize = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Hard Disk Size (in TB):");
                        desktopObj.HardDiskSize = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Graphic Card Size (in GB):");
                        desktopObj.GraphicCard = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Monitor Size (in inches):");
                        desktopObj.MonitorSize = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Power Supply Volt (in volts):");
                        desktopObj.PowerSupplyVolt = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Desktop Price is: " + desktopObj.DesktopPriceCalculation());
                        break;
                    }

                case 2:
                    {
                        laptopObj = new Laptop();

                        Console.WriteLine("Enter Processor Name:");
                        laptopObj.Processor = Console.ReadLine();

                        Console.WriteLine("Enter Ram Size (in GB):");
                        laptopObj.RamSize = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Hard Disk Size (in TB):");
                        laptopObj.HardDiskSize = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Graphic Card Size (in GB):");
                        laptopObj.GraphicCard = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Display Size (in inches):");
                        laptopObj.DisplaySize = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Battery Volt (in volts):");
                        laptopObj.BatteryVolt = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Laptop Price is: " + laptopObj.LaptopPriceCalculation());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Inavlid Input!");
                        return;
                    }
            }
        }
    }
}
