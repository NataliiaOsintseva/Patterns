using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.Factory;
using ComputerFactory.ComputerWarehouse;
using ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory;

namespace ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS
{
    public class Windows10 : IComponent<OSFactory>, IWindows
    {
        public void Operate()
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
