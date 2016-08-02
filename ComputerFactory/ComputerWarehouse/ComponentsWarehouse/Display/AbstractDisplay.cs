using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Display
{
    abstract class AbstractDisplay
    {
        public abstract void Interact(AbstractMotherBoard motherboard);
    }
}
