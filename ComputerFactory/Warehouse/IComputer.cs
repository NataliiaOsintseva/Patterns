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

namespace ComputerFactory.Warehouse
{
    interface IComputer
    {
        AbstractBios Bios { get; set; }
        AbstractCPU Cpu { get; set; }
        AbstractDisplay Display { get; set; }
        AbstractHDD Hdd { get; set; }
        AbstractManipulator Keyboard { get; set; }
        AbstractManipulator Mouse { get; set; }
        AbstractMotherBoard Motherboard { get; set; }
        AbstractOS Os { get; set; }
        AbstractRAM Ram { get; set; }

        void Run();

    }
}
