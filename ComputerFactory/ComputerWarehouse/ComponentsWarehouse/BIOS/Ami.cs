using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.BIOS
{
    class Ami : AbstractBios
    {
        public override void Interact(AbstractMotherBoard motherboard)
        {
            Console.WriteLine(this + " interacts with " + motherboard);
        }
    }
}
