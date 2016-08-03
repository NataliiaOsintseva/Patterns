using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerFactory.ComputerWarehouse;

namespace ComputerFactory.ComputerWarehouse.Factory
{
    public interface IComponentFactory<TFactory>
    {
        TComponent Build<TComponent>() where TComponent : IComponent, new();
    }
}
