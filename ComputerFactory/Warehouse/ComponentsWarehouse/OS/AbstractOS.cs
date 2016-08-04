using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.Warehouse.ComponentsWarehouse.HDD;
using ComputerFactory.Warehouse.Factory.ComponentsFactory;

namespace ComputerFactory.Warehouse.ComponentsWarehouse.OS
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
