using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory
{
    public class HDDFactory : IFactory<HDDFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent<HDDFactory>, new()
        {
            Console.WriteLine("Creating HDD: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
