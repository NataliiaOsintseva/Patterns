using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory
{
    public class CPUFactory : IFactory<CPUFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent<CPUFactory>, new()
        {
            Console.WriteLine("Creating CPU: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
