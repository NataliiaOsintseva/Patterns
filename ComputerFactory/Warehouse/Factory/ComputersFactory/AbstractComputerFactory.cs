using ComputerFactory.Warehouse.ComponentsWarehouse;
using ComputerFactory.Warehouse.ComponentsWarehouse.BIOS;
using ComputerFactory.Warehouse.ComponentsWarehouse.CPU;
using ComputerFactory.Warehouse.ComponentsWarehouse.Display;
using ComputerFactory.Warehouse.ComponentsWarehouse.HDD;
using ComputerFactory.Warehouse.ComponentsWarehouse.Manipulator;
using ComputerFactory.Warehouse.ComponentsWarehouse.OS;
using ComputerFactory.Warehouse.ComponentsWarehouse.RAM;
using ComputerFactory.Warehouse.Factory.ComponentsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.Factory.ComputersFactory
{
    abstract class AbstractComputerFactory
    {

        public abstract AbstractBios BuildBios();
        public abstract AbstractCPU BuildCPU();
        public abstract AbstractDisplay BuildDisplay();
        public abstract AbstractHDD BuildHDD();
        public abstract AbstractManipulator BuildKeyboard();
        public abstract AbstractManipulator BuildMouse();
        public abstract AbstractMotherBoard BuildMotherboard();
        public abstract AbstractOS BuildOs();
        public abstract AbstractRAM BuildRam();

        public abstract IComputer GetComputer();

    }
}
