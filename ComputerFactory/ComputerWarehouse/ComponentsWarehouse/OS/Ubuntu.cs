using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.HDD;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS
{
    class Ubuntu : AbstractOS, ILinux
    {
        public override void Interact(AbstractHDD hdd)
        {
            Console.WriteLine(this + " interacts with " + hdd);
        }

        public void OpenTerminal()
        {
            Console.WriteLine("Now show me your linux command line skills...");
        }
    }
}
