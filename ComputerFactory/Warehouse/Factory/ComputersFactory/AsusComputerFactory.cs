using ComputerFactory.Warehouse.ComponentsWarehouse;
using ComputerFactory.Warehouse.ComponentsWarehouse.BIOS;
using ComputerFactory.Warehouse.ComponentsWarehouse.CPU;
using ComputerFactory.Warehouse.ComponentsWarehouse.Display;
using ComputerFactory.Warehouse.ComponentsWarehouse.HDD;
using ComputerFactory.Warehouse.ComponentsWarehouse.Manipulator;
using ComputerFactory.Warehouse.ComponentsWarehouse.OS;
using ComputerFactory.Warehouse.ComponentsWarehouse.RAM;
using ComputerFactory.Warehouse.ComputersWarehouse;
using ComputerFactory.Warehouse.Factory.ComponentsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.Factory.ComputersFactory
{
    class AsusComputerFactory : AbstractComputerFactory
    {
        BiosFactory biosFactory = new BiosFactory();
        CPUFactory cpuFactory = new CPUFactory();
        DisplayFactory displayFactory = new DisplayFactory();
        HDDFactory hddFactory = new HDDFactory();
        ManipulatorFactory manipulatorFactory = new ManipulatorFactory();
        MotherboardFactory motherboardFactory = new MotherboardFactory();
        OSFactory osFactory = new OSFactory();
        RAMFactory ramFactory = new RAMFactory();

        public override AbstractBios BuildBios()
        {
            return biosFactory.Build<Award>();
        }

        public override AbstractCPU BuildCPU()
        {
            return cpuFactory.Build<Intel>();
        }

        public override AbstractDisplay BuildDisplay()
        {
            return displayFactory.Build<Sony>();
        }

        public override AbstractHDD BuildHDD()
        {
            return hddFactory.Build<Seagate>();
        }

        public override AbstractManipulator BuildKeyboard()
        {
            return manipulatorFactory.Build<Keyboard>();
        }

        public override AbstractMotherBoard BuildMotherboard()
        {
            return motherboardFactory.Build<AsusMotherBoard>();
        }

        public override AbstractManipulator BuildMouse()
        {
            return manipulatorFactory.Build<Mouse>();
        }

        public override AbstractOS BuildOs()
        {
            return osFactory.Build<Windows10>();
        }

        public override AbstractRAM BuildRam()
        {
            return ramFactory.Build<Transcend>();
        }

        public override IComputer GetComputer()
        {
            BuildBios();
            BuildCPU();
            BuildDisplay();
            BuildHDD();
            BuildKeyboard();
            BuildMouse();
            BuildMotherboard();
            BuildOs();
            BuildRam();

            return new AsusComputer();
        }
    }
}
