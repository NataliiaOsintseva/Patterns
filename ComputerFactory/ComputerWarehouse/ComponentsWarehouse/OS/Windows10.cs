using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.Factory;
using ComputerFactory.ComputerWarehouse;
using ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.HDD;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS
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
