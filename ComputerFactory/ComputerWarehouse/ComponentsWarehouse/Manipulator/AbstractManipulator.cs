using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.Manipulator
{
    abstract class AbstractManipulator
    {
        public abstract void Interact(AbstractMotherBoard motherboard);
    }
}
