using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory.ComputerWarehouse.Factory.ComponentsFactory
{
    public class ManipulatorFactory : IFactory<ManipulatorFactory>
    {
        public TComponent Build<TComponent>() where TComponent : IComponent<ManipulatorFactory>, new()
        {
            Console.WriteLine("Creating Manipulator: " + typeof(TComponent));
            return new TComponent();
        }
    }
}
