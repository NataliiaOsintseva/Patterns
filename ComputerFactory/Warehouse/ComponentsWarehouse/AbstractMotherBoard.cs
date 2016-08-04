using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.ComponentsWarehouse
{
    abstract class AbstractMotherBoard : IComponent
    {
        public virtual void Compose()
        {
            // Should I compose them all here? 
        }

        public virtual void PlugIn()
        {
            // Should it interact with the rest?
        }

        public virtual void Operate()
        {
            Console.WriteLine(this + "  is up and running!");
        }
    }
}
