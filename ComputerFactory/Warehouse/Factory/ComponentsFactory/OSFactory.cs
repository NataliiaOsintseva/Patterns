using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.Warehouse.ComponentsWarehouse.OS;

namespace ComputerFactory.Warehouse.Factory.ComponentsFactory
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
