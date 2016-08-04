using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.Warehouse.ComponentsWarehouse.BIOS
{
    class Award : AbstractBios
    {
        public override void Interact(AbstractMotherBoard motherboard)
        {
            Console.WriteLine(this + " interacts with " + motherboard);
        }
    }
}
