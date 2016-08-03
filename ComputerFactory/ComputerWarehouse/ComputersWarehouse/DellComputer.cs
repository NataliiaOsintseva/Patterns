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

namespace ComputerFactory.ComputerWarehouse.ComputersWarehouse
{
    class DellComputer : IComputer
    {
        BiosFactory biosFact;

        public void Assemble()
        {
            
        }


        public AbstractBios Bios
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractCPU Cpu
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractDisplay Display
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractHDD Hdd
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractManipulator Keyboard
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractMotherBoard Motherboard
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractManipulator Mouse
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractOS Os
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public AbstractRAM Ram
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
