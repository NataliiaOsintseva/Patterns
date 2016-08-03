using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.CPU;
using ComputerFactory.ComputerWarehouse.Factory;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.BIOS;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Display;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.HDD;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Manipulator;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.RAM;
using ComputerFactory.ComputerWarehouse.Factory.ComputersFactory;

namespace ComputerFactory.ComputerWarehouse
{
    // Client class 
    class AssemblerComputer
    {
        public void AssembleComputer(AbstractComputerFactory factory)
        {

            IComputer computer = factory.GetComputer();
            Console.WriteLine("assembled a {0} ", computer.GetType().FullName);

        }
    }
}
