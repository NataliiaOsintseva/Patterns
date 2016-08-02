using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.HDD;
using ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS
{
    abstract class AbstractOS : IComponent
    {
        public abstract void Interact(AbstractHDD hdd);

        public virtual void Operate()
        {
            Console.WriteLine(this + "  is up and running!");
        }
    }
}
