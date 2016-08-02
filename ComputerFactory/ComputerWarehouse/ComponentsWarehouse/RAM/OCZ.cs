using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.RAM
{
    class OCZ : AbstractRAM
    {
        public override void Interact(AbstractMotherBoard motherboard)
        {
            Console.WriteLine(this + " interacts with " + motherboard);
        }
    }
}
