using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS;

namespace ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory
{
    public class OSFactory : IFactory<OSFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent<OSFactory>, new()
        {
            Console.WriteLine("Creating OS: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
