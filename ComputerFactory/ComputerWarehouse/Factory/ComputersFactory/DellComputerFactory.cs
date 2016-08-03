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
using ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory;
using ComputerFactory.ComputerWarehouse.ComputersWarehouse;

namespace ComputerFactory.ComputerWarehouse.Factory.ComputersFactory
{
    class DellComputerFactory : AbstractComputerFactory<DellComputer>
    {
        BiosFactory biosFactory = new BiosFactory();

        public override AbstractCPU BuildCPU()
        {
            throw new NotImplementedException();
        }

        public override AbstractDisplay BuildDisplay()
        {
            throw new NotImplementedException();
        }

        public override AbstractHDD BuildHDD()
        {
            throw new NotImplementedException();
        }

        public override AbstractManipulator BuildKeyboard()
        {
            throw new NotImplementedException();
        }

        public override AbstractMotherBoard BuildMotherboard()
        {
            throw new NotImplementedException();
        }

        public override AbstractManipulator BuildMouse()
        {
            throw new NotImplementedException();
        }

        public override AbstractOS BuildOs()
        {
            throw new NotImplementedException();
        }

        public override AbstractRAM BuildRam()
        {
            RAMFactory fact = new RAMFactory();
            return fact.Build<OCZ>();
        }

        public AbstractBios CreateBios()
        {
            return biosFactory.Build<Ami>();
        }

        public override AbstractBios GetBios()
        {
            throw new NotImplementedException();
        }

        public DellComputer GetComputer()
        {
            return new DellComputer();
        }
    }
}
