using ComputerFactory.ComputerWarehouse.ComponentsWarehouse;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.BIOS;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.CPU;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Display;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.HDD;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Manipulator;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.RAM;
using ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.Factory.ComputersFactory
{
    abstract class AbstractComputerFactory<TCompType> where TCompType : IComputer
    {
        public abstract AbstractBios GetBios();
        public abstract AbstractCPU BuildCPU();
        public abstract AbstractDisplay BuildDisplay();
        public abstract AbstractHDD BuildHDD();
        public abstract AbstractManipulator BuildKeyboard();
        public abstract AbstractManipulator BuildMouse();
        public abstract AbstractMotherBoard BuildMotherboard();
        public abstract AbstractOS BuildOs();
        public abstract AbstractRAM BuildRam();
    }


}
