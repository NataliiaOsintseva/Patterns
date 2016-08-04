using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.Warehouse.Factory;
using ComputerFactory.Warehouse;
using ComputerFactory.Warehouse.Factory.ComponentsFactory;
using ComputerFactory.Warehouse.ComponentsWarehouse.HDD;

namespace ComputerFactory.Warehouse.ComponentsWarehouse.OS
{
    class Windows10 : AbstractOS,  IWindows
    {
        public override void Interact(AbstractHDD hdd)
        {
            Console.WriteLine(this + " interacts with " + hdd);
        }

        override public void Operate()
        {
            Console.WriteLine("Windows 10 is up and running!");
        }

        public void RunEdge()
        {
            Console.WriteLine("Let's search something in internet!");
        }

        public void Start()
        {
            Console.WriteLine("Start button is pressed!");
        }
    }
}
