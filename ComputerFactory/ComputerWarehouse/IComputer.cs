using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.BIOS;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.CPU;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Display;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.HDD;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Manipulator;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.RAM;

namespace ComputerFactory.ComputerWarehouse
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

        //public IComputer(AbstractBios bios, AbstractCPU cpu, AbstractDisplay display,
        //                AbstractHDD hdd, AbstractManipulator keyboard, AbstractManipulator mouse,
        //                AbstractMotherBoard motherboard, AbstractOS os, AbstractRAM ram);

    }
}
