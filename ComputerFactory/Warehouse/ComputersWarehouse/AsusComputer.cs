using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.Warehouse.ComponentsWarehouse;
using ComputerFactory.Warehouse.ComponentsWarehouse.BIOS;
using ComputerFactory.Warehouse.ComponentsWarehouse.CPU;
using ComputerFactory.Warehouse.ComponentsWarehouse.Display;
using ComputerFactory.Warehouse.ComponentsWarehouse.HDD;
using ComputerFactory.Warehouse.ComponentsWarehouse.Manipulator;
using ComputerFactory.Warehouse.ComponentsWarehouse.OS;
using ComputerFactory.Warehouse.ComponentsWarehouse.RAM;

namespace ComputerFactory.Warehouse.ComputersWarehouse
{
    class AsusComputer : IComputer
    {
        public AbstractBios Bios { get; set; }
        public AbstractCPU Cpu { get; set; }
        public AbstractDisplay Display { get; set; }
        public AbstractHDD Hdd { get; set; }
        public AbstractManipulator Keyboard { get; set; }
        public AbstractManipulator Mouse { get; set; }
        public AbstractMotherBoard Motherboard { get; set; }
        public AbstractOS Os { get; set; }
        public AbstractRAM Ram { get; set; }

        public void Run()
        {
            Console.WriteLine("\nAsus is up and running! Let's do some fun, %username%!");
        }
    }
}
