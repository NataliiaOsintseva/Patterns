using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse.ComponentsWarehouse.OS;

namespace ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory
{
    public class OSFactory : IComponentFactory<OSFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent, new()
        {
            Console.WriteLine("Creating OS: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
