using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.BIOS
{
    abstract class AbstractBios
    {
        public abstract void Interact(AbstractMotherBoard motherboard);
    }
}
