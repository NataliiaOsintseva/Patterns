using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.RAM
{
    abstract class AbstractRAM
    {
        public abstract void Interact(AbstractMotherBoard motherboard);
    }
}
